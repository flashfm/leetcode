// Copyright (c) 2024 Alexey Filatov
// 122 - Best Time to Buy and Sell Stock II (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)
// Date solved: 10/17/2024 1:48:56 AM +00:00
// Memory: 42.7 MB
// Runtime: 77 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        if (n==0) {
            return 0;
        }
        var dp = new int[n];
        // dp[i] = max profit to sell on Ith day
        // if we sell on Ith day something that we buy on 0...Ith day, then what profit can be
        // we can do it with 0..I for-loop and taking max
        // but max will depend on prev max, so we don't need a loop, just rolling max
        // max is old max, but possible updated with "- prices[i] + dp[i-1]" expression
        // why such expression is used? because dp[i] = max(price[i] - price[j] + dp[j-1]) where j in 0..I
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
