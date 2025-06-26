# Algorithm Report

Author: Jaelee Jeong

Date: 02/17/24

## 1. Name
Dijkstra Shortest Path

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
Dijkstra Shortest Path algorithm is used to find the shortest path from start to end within a graph. It is an example of a greedy algorithm.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
Dijkstra Shortest Path algorithm finds the shortest path in a graph. It first sets the distance and predecessors to infinity, sets the starting distance to 0, and creates a queue. It then selects the vertex with the smallest distance that has not yet been analyzed and adds it to the queue. It relaxes edges until the shortest path is found.

## 4. Analysis Results

The performance for the shortest path (where $V$ is the number of verticies in the graph and $E$ is the number of edges):

* Using an Array:
    * Worst Case: $O(V^2 + E)$
    * Best Case: $\Omega(V^2 + E))$

* Using a Priority Queue:
    * Worst Case: $O(E log V)$
    * Best Case: $\Omega(E log V)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Dijkstra Shortest Path is used a lot in daily life, such as on the GPS and traffic management.
2. The algorithm is very efficient for non-negative edge weights.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT did not use a priority queue. I would prefer the queue for efficiency.
2. It also included many functions separating the steps of the algorithm. I would prefer not to do that since it takes more code.

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. When it wrote one with a priority queue, it used a boolean for visited. It seems much more efficient with the boolean.
2. It also created a new list for adjacent vertices. It is more code, but makes it more straightforward.

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/da8e460d-bd85-47fa-918d-0036d19c1e7b