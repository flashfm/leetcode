// Copyright (c) 2024 Alexey Filatov
// 1236 - N-th Tribonacci Number (https://leetcode.com/problems/n-th-tribonacci-number)
// Date solved: 11/22/2024 8:21:06 AM +00:00
// Memory: 26.9 MB
// Runtime: 0 ms


public class Solution {
    public int Tribonacci(int n) {
        var dp = new int[n+1];
        if (n>0) {
            dp[1] = 1;
        }
        if (n>1) {
            dp[2] = 1;
        }
        for(var i = 3; i<=n; i++) {
            dp[i] = dp[i-3] + dp[i-2] + dp[i-1];
        }
        return dp[n];
    }
}
