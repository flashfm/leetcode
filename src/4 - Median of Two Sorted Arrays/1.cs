// Copyright (c) 2024 Alexey Filatov
// 4 - Median of Two Sorted Arrays (https://leetcode.com/problems/median-of-two-sorted-arrays)
// Date solved: 2/26/2024 5:58:46 AM +00:00
// Memory: 54.1 MB
// Runtime: 93 ms


public class Solution {
    int[] a;
    int[] b;

    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        a = nums1;
        b = nums2;

        var na = a.Length;
        var nb = b.Length;
        var n = na+nb;
        if (n % 2 == 0) {
            var k1 = Find(0, na-1, 0, nb-1, n / 2);
            var k2 = Find(0, na-1, 0, nb-1, n / 2 - 1);
            return (k1+k2) / 2;
        }
        else {
            return Find(0, na-1, 0, nb-1, n / 2);
        }
    }

    private double Find(int aStart, int aEnd, int bStart, int bEnd, int k)
    {
        if (aStart > aEnd) {
            return b[k - aStart];
        }
        if (bStart > bEnd) {
            return a[k - bStart];
        }
        var aMidIndex = (aStart + aEnd) / 2;
        var bMidIndex = (bStart + bEnd) / 2;
        var aMid = a[aMidIndex];
        var bMid = b[bMidIndex];

        if (k>aMidIndex + bMidIndex) {
            // remove left
            if (aMid > bMid) {
                // remove left B
                return Find(aStart, aEnd, bMidIndex + 1, bEnd, k);
            }
            else {
                // remove left A
                return Find(aMidIndex + 1, aEnd, bStart, bEnd, k);
            }
        }
        else {
            // remove right
            if (aMid > bMid) {
                // remove right A
                return Find(aStart, aMidIndex - 1, bStart, bEnd, k);
            }
            else {
                // remove right B
                return Find(aStart, aEnd, bStart, bMidIndex - 1, k);
            }
        }
    }
}
