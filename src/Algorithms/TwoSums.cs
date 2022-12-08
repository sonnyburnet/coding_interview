// https://leetcode.com/problems/two-sum/

namespace Algorithms.TwoSums;

// 


public class Solution
{
    public int[] BruteForceApproach(int[] list, int target)
    {
        var n = list.Length;
        int? GetPairs(int first, int idx)
        {
            if (idx == n)
            {
                return null;
            }
            else if (first + list[idx] == target)
            {
                return idx;
            }
            else return GetPairs(first, idx + 1);
        }
        var pairs = new int[2];
        for (int i = 0; i < n; i++)
        {
            if (list[i] > target)
            {
                continue;
            }
            else
            {
                var second = GetPairs(list[i], i + 1);
                if (second != null)
                {
                    pairs[0] = i;
                    pairs[1] = (int)second;
                    break;
                }
            }
        }
        return pairs;
    }

    // Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    public int[] LinearApproach(int[] list, int target)
    {
        return new int[] { };
    }
}