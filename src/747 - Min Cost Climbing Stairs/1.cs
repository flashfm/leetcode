// Copyright (c) 2024 Alexey Filatov
// 747 - Min Cost Climbing Stairs (https://leetcode.com/problems/min-cost-climbing-stairs)
// Date solved: 11/22/2024 8:34:47 AM +00:00
// Memory: 42.1 MB
// Runtime: 0 ms


public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var n = cost.Length;
        var dp = new int[n+1]; // cost to be on index I
        dp[0] = cost[0];
        dp[1] = cost[1];
        for(var i = 2; i<n; i++) {
            dp[i] = cost[i] + Math.Min(dp[i-1], dp[i-2]);
        }
        return Math.Min(dp[n-1], dp[n-2]);
    }
}
