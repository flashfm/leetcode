// Copyright (c) 2024 Alexey Filatov
// 4 - Median of Two Sorted Arrays (https://leetcode.com/problems/median-of-two-sorted-arrays)
// Date solved: 10/24/2024 10:00:58 PM +00:00
// Memory: 54.9 MB
// Runtime: 7 ms


public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var n = nums1.Length;
        var m = nums2.Length;
        if (n>m) {
            return FindMedianSortedArrays(nums2, nums1);
        }
        var l = 0; // left in the first array
        var r = n; // right in the first array
        while(l<=r) {
            var i = (l+r) / 2; // med in the first array
            var j = (n+m+1) / 2 - i; // j is in the second array making sure that number_of_elements_left_from_I + number_of_elements_left_from_J = half of total array

            Console.WriteLine($"i={i}, j={j}");

            var iLeft = i==0 ? int.MinValue : nums1[i-1];
            var iRight = i==n ? int.MaxValue : nums1[i]; // number at i is included as min of maxes
            var jLeft = j==0 ? int.MinValue : nums2[j-1];
            var jRight = j==m ? int.MaxValue : nums2[j]; // number at j is included as min of maxes

            if (iLeft <= jRight && jLeft<=iRight) {
                // correct partition found
                return (m+n)%2 == 1
                    ? Math.Max(iLeft, jLeft) // odd length of total array 
                    : (Math.Max(iLeft, jLeft) + Math.Min(iRight, jRight)) / (double)2;
            }
            else if (iLeft > jRight) {
                r = i-1;
            }
            else {
                l = i+1;
            }
        }

        return -1;
    }
}
