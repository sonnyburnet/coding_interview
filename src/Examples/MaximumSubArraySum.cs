namespace Examples.MaximumSubArraySum;

static class MaximumSubArraySum
{
    // O(n3) Time Solution A straightforward way to solve the problem is to go through all possible subarrays, 
    // calculate the sum of values in each subarray and maintain the maximum sum. 
    // The following code implements this algorithm
    public static int? BruteForceSolutionO3(int[] input)
    {

        // int [] array = new int [] {-1, 2, 4, -3, 5, 2, -5, 2 };
        // first step: take -1 as a starting point in the outermost loop (outermost_loop)
        // second loop must begin with outermost_loop + 1: 2
        // go through all the numbers in the second loop beginning with 2
        // -1 + 2, -1 + 2 + 4
        var best = 0;
        var n = input.Length;
        for (var a = 0; a < n; a++)
        {
            for (var b = a; b < n; b++)
            {
                int sum = 0;
                for (var k = a; k <= b; k++)
                {
                    sum += input[k];
                }
                best = Math.Max(best, sum);
            }
        }
        return best;
    }

    public static int? MoreImprovedSolutionO2(int[] input)
    {
        var best = 0;
        var n = input.Length;
        for (var a = 0; a < n; a++)
        {
            var sum = 0;
            for (var b = a; b < n; b++)
            {
                sum += input[b];
                best = Math.Max(best, sum);
            }
        }
        return best;
    }

    public static int? RegularLinearSolution(int[] input)
    {
        var best = 0;
        var sum = 0;
        var n = input.Length;
        for (var k = 0; k < n; k++)
        {
            sum = Math.Max(input[k], sum + input[k]);
            best = Math.Max(best, sum);
        }
        return best;
    }

    public static int? RecursiveLinearSolution(int[] input)
    {
        int? Recursive(int best, int sum, int idx)
        {
            if (idx == 0)
                return Math.Max(best, sum);
            else
            {
                var sum_tmp = Math.Max(input[idx], sum + input[idx]);
                return Recursive(Math.Max(best, sum_tmp), sum_tmp, idx - 1);
            }
        }
        return input.Length == 0 ? 0 : Recursive(int.MinValue, input[0], input.Length - 1);
    }
}