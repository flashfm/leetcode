// Copyright (c) 2024 Alexey Filatov
// 714 - Best Time to Buy and Sell Stock with Transaction Fee (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee)
// Date solved: 11/24/2024 4:28:57 AM +00:00
// Memory: 62.8 MB
// Runtime: 2 ms


public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        var n = prices.Length;
        var inStock = -prices[0];
        var inCash = 0;
        for(var i=1; i<n; i++) {
            var p = prices[i];
            (inStock, inCash) =
                (Math.Max(inCash-p, inStock),
                Math.Max(inStock+p-fee, inCash));
        }
        return Math.Max(inCash, inStock);
    }
}
