namespace Algorithms.FirstBadVersion;


// You are a product manager and currently leading a team to develop a new product.
//Unfortunately, the latest version of your product fails the quality check.
//Since each version is developed based on the previous version, all the versions after a bad version are also bad.
// Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
// You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version.
// You should minimize the number of calls to the API.

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class VersionControl
{
    public bool IsBadVersion(int idx) { return true; }
}


public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int go(int low, int high)
        {
            if (low >= high) return low;
            var idx = low + ( high - low ) / 2;
            var curr_ver = IsBadVersion(idx);
            var prev_ver = IsBadVersion(idx - 1);
            if(prev_ver == false && curr_ver == true)
                return idx;
            else if (prev_ver == false && curr_ver == false)
              return go(idx + 1, high);
            else
              return go(low, idx - 1);

        };
        if(n > 2)
          return go(1, n);
        else if (n == 2)
           return IsBadVersion(2) ? (IsBadVersion(1) ? 1 : 2) : -1;
        else
          return IsBadVersion(1) ? 1 : -1;
    }
}