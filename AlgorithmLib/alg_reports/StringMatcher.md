# Algorithm Report

Author: Jaelee Jeong

Date: 03/02/2024

## 1. Name

String Matcher

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The String Matcher algoirthm is used for finding occurences of patterns within a text. It can also find if the pattern occurs with a shift in the text. 

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The String Matcher algorithm first builds a table with a shift amount, given text, and given pattern. The code then loops through each letter to find if there is a match between the text and pattern. Aterwards, the pattern's longest suffix is added to a map dictionary. 


## 4. Analysis Results

The performance of matching assuming the finite state machine table is already built (where $m$ is the length of the pattern and $n$ is the length of the text being checked)

* Worst Case: $O(n+m)$
* Best Case: $\Omega(n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. The string matcher algorithm is used a lot in our daily lives, such as for search engines, spell checkers, and text editors.
2. The algorithm is best to use when there are patterns with repetitive elements.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT's code only used 2 nested loops instead of 3 loops. This makes the code very simple to read. I would like to adopt this.
2. ChatGPT did not use a pka with a substring. It used indexing instead. Without pka, the code is a bit longer, but easier to understand.

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. I understand ChatGPT's code more since it only uses simple concepts, such as indexing and if loops.
2. I also would like to use lists instead of dictionaries since the code is simpler. 

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/075240fb-88ce-4641-adcb-41564470f9e2