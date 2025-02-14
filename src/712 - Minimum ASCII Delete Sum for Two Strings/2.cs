// Copyright (c) 2024 Alexey Filatov
// 712 - Minimum ASCII Delete Sum for Two Strings (https://leetcode.com/problems/minimum-ascii-delete-sum-for-two-strings)
// Date solved: 12/25/2024 7:45:39 PM +00:00
// Memory: 41.8 MB
// Runtime: 14 ms


public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        var dp = new int[s2.Length+1, s1.Length+1];
        // J==0 means that we do not remove whything from s2
        for(var j=1; j<s1.Length+1; j++) {
            dp[0, j] = s1[j-1] + dp[0, j-1];
        }
        for(var i = 1; i<s2.Length+1; i++) {
            var c2 = s2[i-1];
            dp[i, 0] = c2 + dp[i-1, 0];
            for(var j=1; j<s1.Length+1; j++) {
                var c1 = s1[j-1];
                dp[i,j] = Math.Min(
                    (c1==c2 ? 0 : c1+c2)+dp[i-1, j-1],
                    Math.Min(
                        c1 + dp[i, j-1],
                        c2 + dp[i-1, j]
                    ));
            }
        }
        return dp[s2.Length, s1.Length];
    }
}
