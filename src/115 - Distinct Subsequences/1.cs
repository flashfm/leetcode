// Copyright (c) 2024 Alexey Filatov
// 115 - Distinct Subsequences (https://leetcode.com/problems/distinct-subsequences)
// Date solved: 12/26/2024 3:21:40 AM +00:00
// Memory: 43.1 MB
// Runtime: 10 ms


public class Solution {
    public int NumDistinct(string s, string t) {
        var dp = new int[s.Length, t.Length];
        for(var j=0; j<t.Length; j++) {
            var c1 = t[j];
            var prev = 0;
            for(var i=j; i<s.Length; i++) {
                var c2 = s[i];
                if (c1==c2) {
                    dp[i,j] = (i-1<0 || j-1<0 ? 1 : dp[i-1, j-1]) + prev;
                    prev = dp[i,j];
                }
                else {
                    dp[i,j] = prev;
                }
            }
        }
        // Console.WriteLine(string.Join(",", Enumerable.Range(0, s.Length).Select(i => dp[i, 0])));
        // Console.WriteLine(string.Join(",", Enumerable.Range(0, s.Length).Select(i => dp[i, 1])));

        return dp[s.Length-1,t.Length-1];
    }
}
