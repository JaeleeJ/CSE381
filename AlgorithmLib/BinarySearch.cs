namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        
        var NOT_FOUND = -1;
        // beginning of list
        var p = 0;
        // length
        var r = data.Count - 1;
        
        while (p.CompareTo(r) <= 0)
        {
            // midpoint
            var q = (p + r) / 2;
            
            if (data[q].Equals(target))
            {
                return q;
            }
            else if (data[q].CompareTo(target) > 0)
            {
                r = q - 1;
            }
            else if (data[q].CompareTo(target) < 0)
            {
                p = q + 1;
            }
        }
        

        return NOT_FOUND;
    }
}