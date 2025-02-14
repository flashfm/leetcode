// Copyright (c) 2022 Alexey Filatov
// 279 - Perfect Squares (https://leetcode.com/problems/perfect-squares)
// Date solved: 10/19/2022 6:54:33 AM +00:00
// Memory: 26.4 MB
// Runtime: 84 ms


public class Solution {
    public int NumSquares(int n) {
        var dp = new int[n+1];
        for(var i = 1; i<=n; i++) {
            dp[i] = int.MaxValue;
            for(var j = 1; j*j<=i; j++) {
                dp[i] = Math.Min(dp[i], dp[i - j*j] + 1);
            }
        }
        return dp[n];
    }
}
