namespace Examples.SortingAndSearching;

using System.Linq;
using System.Diagnostics;
using System.IO;

class SortingAndSearching
{

    public static int[] BubbleAlgorithm(int[] origin)
    {
        var n = origin.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (origin[j] > origin[j + 1])
                {
                    void swap()
                    {
                        int temp = origin[j];
                        origin[j] = origin[j + 1];
                        origin[j + 1] = temp;
                    }
                    swap();
                }
            }
        }
        return origin;
    }

    /// <summary>
    /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
    public static int[] MergeAlgorithm(int[] origin)
    {
        int[] merge(int[] first, int[] second)
        {
            var tmp = new int[first.Length + second.Length];
            var first_idx = 0;
            var second_idx = 0;
            var tmp_idx = 0;
            while (first_idx < first.Length && second_idx < second.Length)
            {
                if (first[first_idx] < second[second_idx])
                {
                    tmp[tmp_idx++] = first[first_idx++];
                }
                else
                {
                    tmp[tmp_idx++] = second[second_idx++];
                }
            }
            while (second_idx < second.Length)
            {
                tmp[tmp_idx++] = second[second_idx++];
            }
            while (first_idx < first.Length)
            {
                tmp[tmp_idx++] = first[first_idx++];
            }
            return tmp;
        }

        int[] sort(int[] list, int l, int r)
        {

            int[] go(int[] list, int l, int r)
            {
                var m = l + (r - l) / 2;
                var sorted_left = sort(list, l, m);
                var sorted_right = sort(list, m + 1, r);
                return merge(sorted_left, sorted_right);
            }
            return (list.Length, l < r) switch
            {
                (0, _) => list,
                (1, _) => list,
                (_, true) => go(list, l, r),
                (_, _) => new int[] { list[l] }
            };

        };
        return sort(origin, 0, origin.Length - 1);
    }

    public static int BinarySearchByJump(int[] arr, int x)
    {
        int k = 0;
        var n = arr.Length - 1;
        for (int b = n / 2; b >= 1; b /= 2)
        {
            while (k + b < n && arr[k + b] <= x) k += b;
        }
        if (arr[k] == x)
        {
            // x found at index k
            return k;
        }
        else { return -1; }
    }

    public static void Swap(int[] arr)
    {
        void go(int[] arr, int ptr)
        {
            if (ptr > arr.Length - 1)
                return;
            var k = ptr - 1;
            while (k >= 0)
            {
                if (arr[k] > arr[k + 1])
                {
                    var tmp = arr[k + 1];
                    arr[k + 1] = arr[k];
                    arr[k] = tmp;
                    k--;
                }
                else break;
            };
            go(arr, ptr + 1);
        }
        go(arr, 1);
    }

     // heap and heap sort

}