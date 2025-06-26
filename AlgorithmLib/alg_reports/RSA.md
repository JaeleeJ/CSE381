# Algorithm Report

Author: Jaelee Jeong

Date: 03/09/24

## 1. Name
RSA Encryption

## 2. Overview & Purpose
<!-- Describe the purpose of the algorithm and what it is used for. -->
The RSA Encryption encrypts and decrypts using public and private keys. It is used for secure communications. 

## 3. Methodology
<!-- Describe the design of the algorithm.  This should be detailed enough to both understand how the algorithm works and be sufficient to code in any language.  Detailed descriptions will be more than 100 words. 

The inclusion of a picture describing the how the algorithm works will earn bonus points.
![](images/smile.png) -->
The RSA Encryption Algorithm generates a pair of crypotgraphic keys, including a public key and a private key which are large prime numbers. A public exponent, e, is chosen as a small prime number. It is used when generating the private key and encrypting. When generating the private key, the Euclid Algorithm is used to find the modular multiplicative inverse of e mod r. This is used to find the private exponent, d. The algorithm also uses the multiplicative inverse and linear combinations in the encryption and decryption of the text.

## 6. Analysis Results

The performance for the modular exponentiation (where $n$ is the exponent value)

* Worst Case: $O(log n)$
* Best Case: $\Omega(log n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. RSA uses the Euclid Algorithm for modular arithmetic, which is fundamental for cryptography.
2. RSA encryption is used in our daily lives in authentication and software protection.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. ChatGPT only uses 2 classes - encryption and decryption. I think it is not as thorough as the one from the book.
2. ChatGPT uses byte data instead of big integers. I will continue with big integers since I have never used bytes in code.

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. ChatGPT used a ExportParameters method to generate the public and private keys. I would like to try that to save coding time.
2. The way ChatGPT decrypted was interesting since it used something called RSACryptoServiceProvider. 

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/4ecbf59e-cc50-4d32-9d2a-fa152efae235 

