// Copyright (c) 2024 Alexey Filatov
// 1087 - Longest Arithmetic Subsequence (https://leetcode.com/problems/longest-arithmetic-subsequence)
// Date solved: 12/28/2024 7:02:39 PM +00:00
// Memory: 45.9 MB
// Runtime: 75 ms


public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        var result = 0;
        var len = new int[1001, 1001];
        for(var i=0; i<nums.Length; i++) {
            for(var j=0; j<i; j++) {
                var d = nums[i]-nums[j]+500;
                var val = len[i, d] = Math.Max(len[i, d], Math.Max(len[j, d], 1) + 1);
                result = Math.Max(result, val);
            }
        }
        return result;
    }
}
