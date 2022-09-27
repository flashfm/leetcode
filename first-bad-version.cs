// First Bad Version
// https://leetcode.com/problems/first-bad-version
// Date solved: 03/16/2020 05:30:22 +00:00

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
