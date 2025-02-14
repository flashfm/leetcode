// Copyright (c) 2024 Alexey Filatov
// 1087 - Longest Arithmetic Subsequence (https://leetcode.com/problems/longest-arithmetic-subsequence)
// Date solved: 12/28/2024 7:00:19 PM +00:00
// Memory: 98.5 MB
// Runtime: 1872 ms


public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        var result = 0;
        var len = new Dictionary<(int, int), int>();
        for(var i=0; i<nums.Length; i++) {
            for(var j=0; j<i; j++) {
                var d = nums[i]-nums[j];
                var val = len[(i, d)] = Math.Max(len.GetValueOrDefault((i, d)), len.GetValueOrDefault((j,d), 1) + 1);
                result = Math.Max(result, val);
            }
        }
        return result;
    }
}
