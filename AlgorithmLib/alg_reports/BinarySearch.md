# Algorithm Report

Author: Jaelee Jeong

Date: 01/22/24

## 1. Name
Binary Search

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The Binary Search algorithm is used to search for a target through a sorted list. It will search through the list starting from the middle to the front or end until it finds the target.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.-->
![](images/smile.png) 
The Binary Search algorithm searches for a target in a sorted list. Because it is sorted, the algorithm starts from the midpoint of the list. If the target is greater than the midpoint, it takes the midpoint of the greater half of the list. If the target is less than the midpoint, the algorithm will find the midpoint of the lower half and so on. It basically divides halves into halves until the target is found.

## 4. Analysis Results

The performance for the search (where $n$ is the number of items in the list):

* Worst Case: $O(log n)$
* Best Case: $\Omega(1)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Loop-based binary search is better for computer memory compared to recursive binary search.
2. Binary search has one of the most efficient time complexities among search algorithms, such a linear searches. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT's binary search is almost the same besides the variable names. One difference is that the algorithm does not use IComparable when comparing the sides after finding the midpoint. IComparable makes the algorithm more flexible, so I would not change that in my code.
2. Another difference is that ChatGPT uses an array instead of a list. Either would work well, but I prefer lists. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. I would not change anything. After I asked why ChatGPT chose to write the code that way instead of the way it is written in the book and the code I wrote, it said the way I wrote it is better. 
2. I also would not change anything because the algorithm ChatGPT wrote is very similar to mine besides syntax that it likely would not change performance much or at all. 

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/d187ce56-da25-42e6-84b4-dd319864e646