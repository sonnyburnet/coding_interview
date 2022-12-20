namespace Algorithms.DynamicProgramming;

using System.Collections.Generic;

// {1, 3, 4}
// solve(0) => 0
// solve(1) => 1 {1}
// solve(2) => 2 {1, 1}
// solve(3) => 1 {3}
// solve(4) => 1 {4}
// solve(5) => 2 {1, 4}
// solve(6) => 2 {3, 3}
// solve(7) => 2 {3, 4}
// solve(8) => 2 {4, 4}
// solve(9) => 3 {4, 4, 1}
// solve(10) => 3 {3, 3, 4}

// The time complexity of the algorithm is O(nk), where n is the target sum and k is the number of coins.
// solve(x) = min(solve(x − 1) + 1, solve(x − 3) + 1, solve(x − 4) + 1).

// solve(x) = min(solve(x - y1) + 1,  solve(x - y2) + 1, solve(x - y3) + 1, .... , solve(x - yk) + 1)


public class Solution
{
    public static int RecursiveApproach(int[] coins, int target, bool[] ready, int[] value, int[] solution_coins)
    {
        int go(int t)
        {
            if (t < 0) return 0;
            if (t == 0) return 0;
            if (ready[t]) return value[t];
            var best = int.MaxValue;
            foreach (var c in coins)
            {
                best = Math.Min(best, go(t - c) + 1);
                solution_coins[t] = c;
            }

            ready[t] = true;
            value[t] = best;
            return best;
        }
        return go(target);
    }

    public static int[] LongestIncreasingSubSeq(int[] list)
    {
        var n = list.Length;
        var length = new int[n];
        for (int k = 0; k < n; k++)
        {
            length[k] = 1;
            for (int i = 0; i < k; i++)
            {
                if (list[i] < list[k])
                {
                    length[k] = Math.Max(length[k], length[i] + 1);
                }
            }
        }
        return length;
    }

    // Our next problem is to find a path from the upper-left corner to the lower-right corner of an n × n grid,
    // with the restriction that we may only move down and right.
    // Each square contains an integer, and the path should be constructed so that the sum of the values along the path is as large as possible.

    // Assume that the rows and columns of the grid are numbered from 1 to n, and value[y][x] equals the value of square (y, x).
    // Let sum(y, x) denote the maximum sum on a path from the upper-left corner to square (y, x).
    // Then, sum(n, n) tells us the maximum sum from the upper-left corner to the lower-right corner. For example, in the above grid, sum(5, 5) = 67. Now we can use the formula
    // sum(y, x) = max(sum(y, x − 1),sum(y − 1, x)) + value[y][x]
    // which is based on the observation that a path that ends at square (y, x) can come either from square (y, x − 1) or from square (y − 1, x)

    public static int PathsInGrid(int [,] grid)
    {
        int go(int x, int y)
        {
            if(x == grid.GetLength(0) && y == grid.GetLength(1))
              return 0;
            if(x == grid.GetLength(0))
              return go(grid.GetLength(0), y + 1);
            if(y == grid.GetLength(1))
              return go(x + 1, grid.GetLength(1));
            var max_from_left = go(x + 1, y);
            var max_from_above = go(x, y + 1);
            return Math.Max(max_from_left, max_from_above) + grid[x, y];
        }
        return go(0, 0);
    }

}