// Copyright (c) 2024 Alexey Filatov
// 122 - Best Time to Buy and Sell Stock II (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)
// Date solved: 10/17/2024 2:24:02 AM +00:00
// Memory: 42.6 MB
// Runtime: 64 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        if (n==0) {
            return 0;
        }
        var cash = new int[n+1];
        var stock = new int[n+1];
        stock[0] = int.MinValue;
        for(var i = 0; i<n; i++) {
            var p = prices[i];
            stock[i+1] = Math.Max(stock[i], cash[i] - p);
            cash[i+1] = Math.Max(cash[i], stock[i] + p);
        }
        return cash[n];
    }
}
