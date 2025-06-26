# Algorithm Report

Author: Jaelee Jeong

Date: 03/23/24

## 1. Name
Convex Hull Algorithm

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
A convex hull contains all the points with the smallest perimeter. The Convex Hull Algorithm takes a list of points and returns the points that represent the convex hull that includes those points.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The Convex Hull Algorithm contains a Point class and a few functions. The Point class defines a point with X and Y coordinates. In a separate function, the orientation of the points is found with a cross product. If the cross product is positive, then the points are counterclockwise, if it is negative then they are clockwise, and if it is zero, then the points are colinear. After the cross product is found, the anchor of the hull is found as the leftmost lowest Y coordinate point. Then the points are sorted by angle and distance relative to the anchor. The hull is generated with the first three sorted points then the remaining points after that are convex. The convex hull is generated when the anchor point is added to the hull again. 

## 4. Analysis Results

The performance for generating the convex hull (where $n$ is the number points):

* Worst Case: $O(n^2)$
* Best Case: $\Omega(n log n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. The Convex Hull Algorithm is used for image processing and computer graphics.
2. The algorithm is best to use when memory is limited and the convex hull size is not too large.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT uses a stack to hold the points for the convex hull. It seems to be similar in the way the hull is generated with it, so I would not change my code to be that way.
2. ChatGPT uses a list to sort the points, but is able to sort them all with two lines of code. I would like this for my algorithm since mine took about 8 lines. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. I would like to sort the points in the way ChatGPT did with the OrderBy.ThenBy methods. 
2. I also would like to use ChatGPT's Orientation function since the way it finds the cross products of the points is very simple.

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
https://chat.openai.com/share/b48f823f-0c9d-41fc-a8a8-54afe27873d2 