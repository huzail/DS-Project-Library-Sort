# DS-Project-Library-Sort
##  Topic Library Sort

##  Group Members

1. Syed Muhammad Huzail Akhter Roll No. 17B-035-SE
2. Zubair Shahid Roll No. 17B-023-SE
3. Talal Siddiqui Roll No. 17B-007-SE

## Introduction
Library Sort is a sorting algorithm which is drived from insertion sort the major difference between the Library Sort and the Insertion sort is that it has gaps and the time complexity:
### Time Complexity
                                       Average CaseComplexity    O(n logn)
                                       Worst Case Complexity     O(n^2)
                                       Best Case Complexity      O(n)

## Algorithm Explanation
Library Sorting algorithm is the extension of insertion sort algorithm. In insertion gaps are inserted after each each element in array the author has not define the amount of gaps but it is denoted by epsilon. We use concept of rebalancing an array after insertion of elements in array. However it is not necessary that we rebalance the array after each insertion depending on the size of epsilon but in our implementation we did rebalancing after each insertion as we are placing 1 gap after each insertion. These are some of the cases we need to resolve before starting the implementation of algorithm These are the steps of the algorithm:
### Binary Search
In library first step is we do binary search to find out the exact postion of index where we want to inset our elements.
### Insertion 
We use insertion sort to place the value in the gaps.
### Rebalancing 
In last step we do rebalncing to create gaps between each elements.

## Platform Support
Our Project is implemented in C# and can be used in any Version of Visual Studio however We have complied it in Visual Studio 2017 and Visual Studio 2013. 

## Basic Implementation
We are using Arrays in this project but one can also use Lists in order to implement this project. 

## How To Test Code?
              First Intialize the Size of Array
              Here we are using User Define input so put values in array (Avoide negative values)
              All Code will run automatically and you will see final output (With Gaps) on the screen
              We are also showing detail steps of our working of algorithm with output
              NOTE: Library Sort is made using the concept of sorting books in library so as books can not be negative so negative values are also not given as input in the code and can cause errors in final steps

