// Merge Sorted Array
// https://leetcode.com/problems/merge-sorted-array
// Date solved: 03/09/2020 03:42:51 +00:00

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var p1 = n+m-1;
        var p2 = n-1;
        var p3 = m-1;
        while(p1>=0) {
            var n2 = p2>=0 ? nums2[p2] : int.MinValue;
            var n3 = p3>=0 ? nums1[p3] : int.MinValue;
            if (n2>n3) {
                nums1[p1--] = n2;
                p2--;
            }
            else {
                nums1[p1--] = n3;
                p3--;
            }
        }
    }
}
