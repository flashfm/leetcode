// Copyright (c) 2024 Alexey Filatov
// 1250 - Longest Common Subsequence (https://leetcode.com/problems/longest-common-subsequence)
// Date solved: 10/27/2024 3:12:18 AM +00:00
// Memory: 37.9 MB
// Runtime: 7 ms


public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if (text1.Length<text2.Length) {
            return LongestCommonSubsequence(text2, text1);
        }
        var dp = new int[text1.Length];
        var prev = new int[dp.Length];
        var result = 0;
        foreach(var c in text2) {
            var max = 0;
            for(var i = 0; i<text1.Length; i++) {
                if (text1[i]==c) {
                    dp[i] = Math.Max(prev[i], max+1);
                    result = Math.Max(result, dp[i]);
                }
                else {
                    dp[i] = prev[i];
                }
                max = Math.Max(max, prev[i]);
            }
            (dp, prev) = (prev, dp);
        }
        return result;
    }
}
