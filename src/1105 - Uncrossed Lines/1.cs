// Copyright (c) 2025 Alexey Filatov
// 1105 - Uncrossed Lines (https://leetcode.com/problems/uncrossed-lines)
// Date solved: 1/3/2025 7:54:50 PM +00:00
// Memory: 41.2 MB
// Runtime: 2 ms


public class Solution {
    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        var n1 = nums1.Length;
        var news = new int[n1];
        var olds = new int[n1];
        var result = 0;
        foreach(var n in nums2) {
            var max = 0;
            for(var i=0; i<n1; i++) {
                news[i] = Math.Max(olds[i], nums1[i]==n ? max+1 : max);
                max = Math.Max(max, olds[i]);
                result = Math.Max(result, news[i]);
            }
            (olds, news) = (news, olds);
        }
        return result;
    }
}
