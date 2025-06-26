using System.Collections;

namespace AlgorithmLib;

public static class ConvexHull
{
    private const double DoubleTolerance = 0.001;

    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point point)
        {
            return Math.Abs(X - point.X) < DoubleTolerance && 
                   Math.Abs(Y - point.Y) < DoubleTolerance;
        }
    }

    private static int Orientation(Point a, Point b, Point c)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        // get cross product
        var cross_prod = (b.X - a.X) * (c.Y - b.Y) - (b.Y - a.Y) * (c.X - b.X);
        // colinear
        if (cross_prod == 0)
        {
            return 0;
        }
        // counterclockwise
        else if (cross_prod > 0)
        {
            return 1;
        }
        // clockwise
        else
        {
            return 2;
        }
        
    }
    
    // If needed, you can create more private functions to be used by the 
    // GenerateHull function below.

    public static List<Point> GenerateHull(List<Point> points)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        // convex hull not possible with under 3 points -> triangle
        if (points.Count < 3)
        {
            return null;
        }
        
        // get anchor as leftmost, lowest y coordinate
        Point anchor = points[0];

        foreach (Point point in points)
        {
            if (point.Y < anchor.Y || (point.Y == anchor.Y && point.X < anchor.X))
            {
                anchor = point;
            }
        }
        
        // sort points closest to anchor by angle and distance 
        points.Sort((a, b) =>
                {
                    double angleA = Get_angle(anchor, a);
                    double angleB = Get_angle(anchor, b);
                    int compareAngles = angleA.CompareTo(angleB);
                    
                    if (compareAngles == 0)
                    {
                        double distanceA = Get_distance(anchor, a);
                        double distanceB = Get_distance(anchor, b);
                        return distanceA.CompareTo(distanceB);
                    }
                    return compareAngles;
                });
        
        // initialize hull with first 3 points
        List<Point> hull = new List<Point> {points[0], points[1], points[2]};
        
        // build convex hull
        for (int i = 3; i < points.Count; i++)
        {
            // remove when not convex
            while (Orientation(hull[hull.Count - 2], hull[hull.Count - 1], points[i]) != 1)
            {
                hull.RemoveAt(hull.Count - 1);
            }

            // convex alignment
            hull.Add(points[i]);
            
        }
        
        // re-add anchor for the cycle
        hull.Add(hull[0]);
        
        // Print the points in the convex hull
        Console.WriteLine("Points on the convex hull:");
        foreach (var point in hull)
        {
            Console.WriteLine($"{point.X}, {point.Y}");
        }
        
        return hull;
    }
    
    // function for get angle
    private static double Get_angle(Point anchor, Point point)
    {
        return Math.Atan2(point.Y - anchor.Y, point.X - anchor.X);
    }
    
    // function for get distance
    private static double Get_distance(Point anchor, Point point)
    {
        return Math.Sqrt(Math.Pow(point.X - anchor.X, 2) + Math.Pow(point.Y - anchor.Y, 2));
    }
}

