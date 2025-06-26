# Algorithm Report

Author: Jaelee Jeong

Date: 02/26/24

## 1. Name
Bellman Ford Shortest Path

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The Bellman Ford Shortest Path algorithm is used to find the shortest path in a graph. It also can identify a negative weight cycle.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->

The Bellman Ford Shortest Path algorithm is very simple. Like other shortest path algorithms, it uses  distance and predecessor variables. After initializing those, it relaxes all edges n - 1 times. If it finds a negative weight cycle, no relaxing of edges will be done. 

## 4. Performance

The performance for the shortest path (where $V$ is the number of verticies in the graph and $E$ is the number of edges):

* Worst Case: $O(V + E)$
* Best Case: $\Omega(VE)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Although it is not the most efficient shortest path algorithm, the Bellman Ford algorithm is most useful when there are negative edge weights or cycles.
2. The Bellman Ford algorithm is used in our daily lives, such as in network routing and traffic management.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT checks for negative cycles within the same function instead of having sepatate ones. This makes it easier to follow than the eay the book writes a separate function for it.
2. ChatGPT does the relaxing edges part of the code very differently. It is very simple to understand and should be adopted.

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. To check for negative weight cycles, ChatGPT only used two lines of code. I would like to implement that into my code.
2. The way ChatGPT relaxes the edges is very simple as well with only 3 loops, while mine has 5 nested loops. The 3 loops makes the code much easier to read. 

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/35d328a4-8e7b-454d-9ee8-68f22c746791

