// Copyright (c) 2019 Alexey Filatov
// 300 - Longest Increasing Subsequence (https://leetcode.com/problems/longest-increasing-subsequence)
// Date solved: 12/28/2019 4:43:04 AM +00:00
// Memory: 24.1 MB
// Runtime: 108 ms


public class Solution {
    public int LengthOfLIS(int[] nums) {
        var n = nums.Length;
        if (n==0) return 0;
        var maxLenByNum = new int[n];
        for(var i = 0;i<n;i++) {
            var j = FindSequenceLength(nums, maxLenByNum, i);
            maxLenByNum[i] = j+1;
        }
        return maxLenByNum.Max();
    }
    private int FindSequenceLength(int[] nums, int[] maxLenByNum, int start)
    {
        var maxLen = 0;
        var x = nums[start];
        for(var i=0;i<start;i++) {
            if (nums[i]<x) {
                maxLen = Math.Max(maxLen, maxLenByNum[i]);
            }
        }
        return maxLen;
    }
}
