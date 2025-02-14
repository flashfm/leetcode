// Copyright (c) 2020 Alexey Filatov
// 278 - First Bad Version (https://leetcode.com/problems/first-bad-version)
// Date solved: 3/16/2020 5:30:22 AM +00:00
// Memory: 14.5 MB
// Runtime: 40 ms


/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        var l = 1;
        var r = n;
        while(l<=r) {
            var m = l + (r-l)/2;
            if (IsBadVersion(m)) {
                r = m-1;
            }
            else {
                l = m+1;
            }
        }
        return l;
    }
}
