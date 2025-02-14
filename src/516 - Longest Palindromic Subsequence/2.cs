// Copyright (c) 2024 Alexey Filatov
// 516 - Longest Palindromic Subsequence (https://leetcode.com/problems/longest-palindromic-subsequence)
// Date solved: 12/22/2024 5:30:20 AM +00:00
// Memory: 50.7 MB
// Runtime: 50 ms


public class Solution {
    public int LongestPalindromeSubseq(string s) {
        var n = s.Length;
        var dp = new int[n, n];
        for(var j=0; j<n; j++) {
            for(var i=j; i>=0; i--) {
                if (i==j) {
                    dp[i, j] = 1;
                }
                else {
                    if (s[j]==s[i]) {
                        dp[i, j] = Math.Max(dp[i, j], 2 + (i+1<=j-1 ? dp[i+1, j-1] : 0));
                    }
                    if (j-1>=0) {
                        dp[i, j] = Math.Max(dp[i, j], dp[i, j-1]);
                    }
                    if (i+1<j) {
                        dp[i, j] = Math.Max(dp[i, j], dp[i+1, j]);
                    }
                }
            }
        }
        return dp[0, n-1];
    }
}
