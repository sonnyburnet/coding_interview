namespace Algorithms.ValidPalindrome;

using System;
using System.Linq;


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


/**

0123456789
race a car

1 r (0) r(9) =>  forward_idx = 1, backward_idx = 8 -> step 6 true
2 a(1) a(8)  =>  forward_idx = 2, backward_idx = 7 -> step 6 true 
3 c (2) c (7) =>  forward_idx = 3, backward_idx = 6 -> step 6 true 
4 e (3)  " " (6) => forward_idx = 3, backward_idx = 5 -> step 3 false
5 e (3) a (5) =>  forward_idx = 4, backward_idx = 4 -> step 6 false
6 " " " "

**/



public class Solution
{
    public static bool IsPalindrome(string s)
    {
        bool fold(string s, int forward_idx, int backward_idx, bool result)
        {
            var fchar = Char.ToLower(s[forward_idx]);
            var bchar = Char.ToLower(s[backward_idx]);
            var l = s.Length;
            return
            (l == 1,
             forward_idx >= backward_idx,
             Char.IsLetterOrDigit (fchar),
             Char.IsLetterOrDigit(bchar))
             switch
            {
                (true, _, _, _) => true, // 1
                (_, true, _, _) => result, // 2
                (_, _, true, false) => fold(s, forward_idx, backward_idx - 1, result), // 3
                (_, _, false, true) => fold(s, forward_idx + 1, backward_idx, result), // 4
                (_, _, false, false) => fold(s, forward_idx + 1, backward_idx - 1, result), // 5
                _ => fold(s, forward_idx + 1, backward_idx - 1, result && fchar == bchar) // 6
            };
        };
        return fold(s, 0, s.Length - 1, true);
    }
}