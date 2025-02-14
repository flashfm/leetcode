// Copyright (c) 2024 Alexey Filatov
// 806 - Domino and Tromino Tiling (https://leetcode.com/problems/domino-and-tromino-tiling)
// Date solved: 11/24/2024 3:30:53 AM +00:00
// Memory: 27.1 MB
// Runtime: 0 ms


public class Solution {
    public int NumTilings(int n) {
        var dp = new int[n+1];
        var dpBottomFree = new int[n+1];
        var dpTopFree = new int[n+1];
        var mod = 1000000007;
        dp[0] = 1;
        dp[1] = 1; // |
        if (n>1) {
            dp[2] = 2;
            dpTopFree[2] = 1;
            dpBottomFree[2] = 1;
        }
        for(var i=3; i<=n; i++) {
            dp[i] = (dp[i] + dp[i-1]) % mod;
            dp[i] = (dp[i] + dp[i-2]) % mod;
            dp[i] = (dp[i] + dpTopFree[i-1]) % mod;
            dp[i] = (dp[i] + dpBottomFree[i-1]) % mod;

            dpTopFree[i] = (dp[i-2] + // L
                dpBottomFree[i-1]) % mod; // _

            dpBottomFree[i] = (dp[i-2] + // r
                dpTopFree[i-1]) % mod; // -
        }
        return dp[n];        
    }
}
