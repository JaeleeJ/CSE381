# Algorithm Report

Author: Jaelee Jeong

Date: 03/16/24

## 1. Name
Huffman Tree Compression

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The Huffman Tree Compression algorithm is used for data compression to encode nodes with binary codes. The algorithm reduces each node's bit size.

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The Huffman Tree Compression starts by making a profile of frequency of characters in a string. It then builds a Huffman Tree based on the profile. After, each character is encoded with a binary code. To decode it, the code traverses the tree starting from the root to the leaf nodes until the entire tree is decoded.


## 4. Analysis Results

The performance for the encode and decode (where $m$ is the number of huffman codes and $n$ is the length of text to encode or decode)

* Encode:
    * Worst Case: $O(m)$
    * Best Case: $\Omega(m)$
* Decode:
    * Worst Case: $O(n)$
    * Best Case: $\Omega(n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. It is a lossless compression algorithm while staying efficient due to the use of binary codes.
2. The algorithm is relatively simple to implement compared to other compression algorithms.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT used a sorted dictionary instead of a regular dictionary for efficieny searching. I would not implement this because it takes more memory.
2. When building the tree, ChatGPT uses pair values instead of nodes. It includes a lot more code than using nodes, so I would not adopt that.

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. I like how ChatGPT has a separate function called Traverse to traverse left and right through the tree. It seems to make the code simpler when assigning the binary codes.
2. I don't prefer any of the other methods ChatGPT used as there is a lot of excess code that could be written simpler compared to the algorithm in the book.

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
https://chat.openai.com/share/9432191d-fb9d-4bca-acc3-19e3a701d824 
