namespace Algorithms.ValidAnagram;


// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

public class Solution {
    public bool IsAnagram(string s, string t) {
        
    }

    public static int Search(int[] nums, int target)
    {
        int go(int[] list, int target, int low, int high)
        {
            var mid = (low + high) / 2;
            if(mid > high || mid < low) return -1;
            else if (list[mid] == target) return mid;
            else if (list[mid] > target) return go(list, target, low, mid);
            else return go(list, target, mid, high);
        }
        return go(nums, target, 0, (nums.Length - 1) / 2);
    }


}
