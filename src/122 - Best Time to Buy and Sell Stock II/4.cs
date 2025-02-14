// Copyright (c) 2024 Alexey Filatov
// 122 - Best Time to Buy and Sell Stock II (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)
// Date solved: 10/16/2024 10:10:27 PM +00:00
// Memory: 42.4 MB
// Runtime: 333 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        if (n==0) {
            return 0;
        }
        var dp = new int[n];
        for(var i = 0; i<n; i++) {
            var max = 0;
            for(var j = 0; j<=i; j++) {
                max = Math.Max(max, prices[i] - prices[j] + (j>0 ? dp[j-1] : 0));
            }
            dp[i] = max;
        }
        return dp[n-1];
    }
}
