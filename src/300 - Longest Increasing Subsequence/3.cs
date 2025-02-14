// Copyright (c) 2024 Alexey Filatov
// 300 - Longest Increasing Subsequence (https://leetcode.com/problems/longest-increasing-subsequence)
// Date solved: 12/29/2024 6:14:29 AM +00:00
// Memory: 42.9 MB
// Runtime: 5 ms


public class Solution {
    public int LengthOfLIS(int[] nums) {
        var tails = new int[nums.Length];
        var len = 0;
        foreach(var n in nums) {
            var i = Array.BinarySearch(tails, 0, len, n);
            if (i<0) {
                var idx = ~i;
                tails[idx] = n;
                if (idx==len) {
                    len++;
                }
            }
        }
        return len;
    }
}
