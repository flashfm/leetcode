// Copyright (c) 2020 Alexey Filatov
// 309 - Best Time to Buy and Sell Stock with Cooldown (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown)
// Date solved: 8/4/2020 6:23:42 AM +00:00
// Memory: 24.6 MB
// Runtime: 84 ms


// dp
// buy[i] - max profit for all the transactions when the last (at I or before) ends with "buy"
// sell[i] - max profit for all the transactions when the last (at I or before) ends with "sell"
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length<2) return 0;
        var n = prices.Length;
        var buy = new int[n];
        var sell = new int[n];
        buy[0] = -prices[0];
        buy[1] = Math.Max(buy[0], -prices[1]);
        sell[0] = 0;
        sell[1] = Math.Max(sell[0], buy[0] + prices[1]);
        for(var i = 2; i<n; i++) {            
            buy[i] = Math.Max(buy[i-1], sell[i-2] - prices[i]);
            sell[i] = Math.Max(sell[i-1], buy[i-1] + prices[i]);
        }
        return sell[n-1];
    }
}
