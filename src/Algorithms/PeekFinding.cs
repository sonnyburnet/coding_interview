using System.Diagnostics;

namespace Algorithms.PeekFinding;

public class Solution
{
    public static int? Find(int[] list, int l, int r)
    {
        int? go(int[] list, int l, int r)
        {
            var mid = (r + l) / 2;

            if (mid < r &&
                list[mid] > list[mid - 1] &&
                list[mid] < list[mid + 1])
            { return go(list, mid + 1, r); }
            else if
            (mid > l &&
             list[mid] > list[mid + 1] &&
             list[mid] < list[mid - 1])
            { return go(list, l, mid - 1); }
            else { return list[mid]; }
        };

        return list.Length switch
        {
            0 => null,
            1 => list[0],
            _ => go(list, l, r)
        };
    }
}
