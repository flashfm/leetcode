// Copyright (c) 2020 Alexey Filatov
// 88 - Merge Sorted Array (https://leetcode.com/problems/merge-sorted-array)
// Date solved: 3/9/2020 3:25:47 AM +00:00
// Memory: 30.1 MB
// Runtime: 240 ms


public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var nums3 = (int[])nums1.Clone();
        var p1 = 0;
        var p2 = 0;
        var p3 = 0;
        while(p1<n+m) {
            var n2 = p2<n ? nums2[p2] : int.MaxValue;
            var n3 = p3<m ? nums3[p3] : int.MaxValue;
            if (n2<n3) {
                nums1[p1++] = n2;
                p2++;
            }
            else {
                nums1[p1++] = n3;
                p3++;
            }
        }
    }
}
