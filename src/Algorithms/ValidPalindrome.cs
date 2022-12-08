namespace Algorithms.ValidPalindrome;


// A phrase is a palindrome if, after converting all uppercase letters 
//into lowercase letters and removing all non-alphanumeric characters, 
// it reads the same forward and backward. Alphanumeric characters include letters and numbers.
// Given a string s, return true if it is a palindrome, or false otherwise.


// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.

// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.


// presupposition: the word is a palindrome if it consists of (2n + 1) chars
// expected complexity: O(n/2) 
// steps 
// 1 - get the index points at the middle of a word
// 2 ....


public class Solution {
    public bool IsPalindrome(string s) {
        return true;   
    }
}