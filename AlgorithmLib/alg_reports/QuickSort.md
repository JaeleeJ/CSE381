# Algorithm Report

Author: Jaelee Jeong

Date: 02/03/24

## 1. Name

Quick Sort

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The purpose of the Quick Sort algorithm is to sort an array in a quick and efficient way. It uses a pivot and partitioning to sort. 

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The algorithm is designed to rearrange the elements of the array using a pivot. The pivot is chosen to be the left most value, then compares itself to each of the values. When a value is less than the pivot, it stays where it is and the pivot move to compare to the next element. Once an element is greater than the pivot, the two swap places to make the greater element the new pivot. While doing this, the array is partitioned into 2 sub-arrays: elements that are less than the pivot and elements that are greater than the pivot.


## 4. Analysis Results

The performance of the sort (where $n$ is the number of items in the list):

* Worst Case: $O(n^2)$
* Best Case: $\Omega(n log n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Quick Sort is best for large data sets because it does not require additional memory from its in-place sorting. 
2. Using a random pivot makes the $O(n^2)$ performance less likely. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT uses the last element of the array as the pivot whereas the book uses the letter u from a range to be the pivot. It seems more simplified with the last element as the pivot.
2. It also has another function called Swap that the Partition function calls when needing to swap the elements. This is easy to read, but takes more lines of code than swapping right in the if statement. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. It makes more sense to me to use the last element in an array as the pivot or a random pivot than how the book has a new variable, u, going through a range. 
2. I like how the Sort function was simplified in ChatGPT's code using if(low < high) instead of base cases. It is much simpler that way.

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/3614bb37-bbcd-482a-8efc-f4dcbe04be70 
