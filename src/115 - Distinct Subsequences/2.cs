// Copyright (c) 2024 Alexey Filatov
// 115 - Distinct Subsequences (https://leetcode.com/problems/distinct-subsequences)
// Date solved: 12/26/2024 3:24:21 AM +00:00
// Memory: 42.4 MB
// Runtime: 8 ms


public class Solution {
    public int NumDistinct(string s, string t) {
        var dp = new int[t.Length, s.Length];
        for(var i=0; i<t.Length; i++) {
            var prev = 0;
            for(var j=i; j<s.Length; j++) {
                dp[i,j] = t[i]==s[j] ? (prev = (i-1<0 || j-1<0 ? 1 : dp[i-1, j-1]) + prev) : prev;
            }
        }
        return dp[t.Length-1,s.Length-1];
    }
}
