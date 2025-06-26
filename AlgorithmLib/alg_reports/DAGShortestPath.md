# Algorithm Description Document

Author: Jaelee Jeong

Date: 01/10/24

## 1. Name
Directed Acyclic Graph (DAG) Shortest Path

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The purpose of the Directed Acyclic Graph (DAG) Shortest Path algorithm is to use a graph to find the shortest path among the vertices and edges.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The Directed Acyclic Graph (DAG) algorithm first takes a topological sort to order the vertices in a linear order. It then visits each vertex in order to find the smallest distance of edge between each vetex using nested for and if loops to determine which path is the shortest. The loops will either update the distance or relax the edges until it finds the shortest path.

## 4. Analysis Results

The performance of the shortest path (where $V$ is the number of verticies and $E$ is the number of edges):

* Worst Case: $O(V+E)$
* Best Case: $\Omega(V+E)$

## 5. AI Research

### 5.1

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:
1. The DAG needs to be acyclic or else it could have infinite paths.
2. The DAG Shortest Path algorithm is best to use when there is a critical path analysis needed.

### 5.2

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.
1. ChatGPT used a stack for the topo sort instead of a list or array. It seems to use less lines of code that way.
2. ChatGPT also used a boolean for if the vertices were visited. This also uses less code than having two lists for distance and predecessor.


### 5.3

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:
1. I would like to use the simple if-foreach-if loop for the relaxing edges part of the sort. 
2. I would also like to use the visited boolean ChatGPT uses since it uses less lines of code for the algorithm.

### 5.4

Provide the URL for your discussion in ChatGPT:
https://chat.openai.com/share/23e26e2f-c126-4e96-8170-b6d9c121a646 