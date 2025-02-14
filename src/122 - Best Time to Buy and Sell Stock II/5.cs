// Copyright (c) 2024 Alexey Filatov
// 122 - Best Time to Buy and Sell Stock II (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)
// Date solved: 10/17/2024 1:40:35 AM +00:00
// Memory: 42.6 MB
// Runtime: 69 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        if (n==0) {
            return 0;
        }
        var dp = new int[n]; // dp[i] = max profit to sell on Ith day
        var maxPart = -prices[0];
        for(var i = 1; i<n; i++) {
            maxPart = Math.Max(maxPart, dp[i-1] - prices[i]);
            dp[i] = Math.Max(0, prices[i] + maxPart);
        }
        return dp[n-1];
    }

    // dp0 = 0 
    // dp1 = p1 - p0 + dp-1 = p1 + maxPart (-p0 + dp-1)
    // dp2 = max(p2 - p1 + dp0, p2 - p0 + dp-1) = p2 + maxPart (-p1 + dp0, -p0 + dp-1)
    // dp3 = max(p3 - p2 + dp1, p3 - p1 + dp0, p3 - p0 + dp-1) = p3 + maxPart (- p2 + dp1, - p1 + dp0, - p0 + dp-1)
    // dp4 = max(p4 - p3 + dp2, p4 - p2 + dp1, p4 - p1 + dp0, p4 - p0 + dp-1, p4 - p4 + dp3)
}
