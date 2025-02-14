// Copyright (c) 2024 Alexey Filatov
// 516 - Longest Palindromic Subsequence (https://leetcode.com/problems/longest-palindromic-subsequence)
// Date solved: 12/22/2024 5:32:50 AM +00:00
// Memory: 50.4 MB
// Runtime: 40 ms


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
                    dp[i, j] = Math.Max(
                        s[j]==s[i] ? 2 + (i+1<=j-1 ? dp[i+1, j-1] : 0) : 0,
                        Math.Max(j-1>=0 ? dp[i, j-1] : 0,
                        i+1<j ? dp[i+1, j] : 0)
                    );
                }
            }
        }
        return dp[0, n-1];
    }
}
