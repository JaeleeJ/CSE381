# Algorithm Report

Author: Jaelee Jeong

Date: 01/27/24

## 1. Name
Merge Sort

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The purpose of the Merge Sort algorithm is to sort a list into individual elements, then merge them into sublists to merge into a sorted list.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The algorithm starts with an unsorted list in a Sort function. It then finds the midpoint of the list to separate it in half. It continues to do so until there are the same amount of sublists as there are elements. In the Merge function, it takes those sublists and merges them into two sublists. Those two sublists are merged into one list based on which element is of least value. 

## 4. Analysis Results

The performance of the sort (where $n$ is the number of items in the list):

* Worst Case: $O(n log n)$
* Best Case: $\Omega(n log n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Merge Sort is very efficient for large data sets. 
2. Merge Sort is the most stable of sorting algorithms because it ensures that if two elements have equal values, the one that appeared first will stay first.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT's merge sort included the array, left,and right as parameters in both functions, whereas the assignment had only the data in the Sort function. I like ChatGPT's better.
2. ChatGPT used a while function when comparing the two subarrays. There are many while functions in the Merge function. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. I would like to make the Sort function include the first and last parameters. 
2. I would also like to write the code more simply with first, last, and mid instead of using p, q, and r like how the book has it.

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/45daf77d-33dd-4685-83fc-6770d97a4065
