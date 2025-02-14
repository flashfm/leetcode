// Copyright (c) 2024 Alexey Filatov
// 747 - Min Cost Climbing Stairs (https://leetcode.com/problems/min-cost-climbing-stairs)
// Date solved: 11/22/2024 8:38:17 AM +00:00
// Memory: 41.9 MB
// Runtime: 0 ms


public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var n = cost.Length;
        var i2 = cost[0];
        var i1 = cost[1];
        for(var i = 2; i<n; i++) {
            var i0 = cost[i] + Math.Min(i1, i2);
            (i1,i2) = (i0,i1);
        }
        return Math.Min(i1, i2);
    }
}
