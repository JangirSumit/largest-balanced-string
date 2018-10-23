# Largest balanced string problem solution in C#


An empty sequence is balanced.

A sequence of the form (A) or [A] or {A} is balanced if A is balanced.

A sequence of the form AB is balanced if A and B both are balanced.

 

You are given a string A, consisting of '(', ')', '[', ']', '{' and '}' only. You have to find the maximum length of the balanced string after performing some valid operation(s).

Valid operations are

Remove any character from string A

Swap any two adjacent characters of string A

You can perform these valid operations in any order and any numbers of times.

 

Input Format

The first line of input contains an integer T, denoting the number of the test cases.
Each of the next T lines contains a single string A.

Output Format

For each case, print the maximum length of the balanced string in a separate line.

Input Constraints



 

SAMPLE INPUT 
5

(){}()[]

))[]]((

{{{{{{{}

[]{}]

{}}


SAMPLE OUTPUT 
8

6

2

4

2

Explanation


(){}()[]: This is already balanced so ans = 8. 

))[]](( : By performing few conseqcutive swap you can move last two char to the front. 
          String will look like (())[]]. Then you can remove last character, so final balanced 
          string length is 6.

{{{{{{{}: Remove first 6 characters ans = 2. 

[]{}]   : Remove last character ans = 4.

{}}     : Remove last character ans = 2.
