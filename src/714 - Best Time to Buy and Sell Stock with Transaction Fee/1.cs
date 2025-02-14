// Copyright (c) 2024 Alexey Filatov
// 714 - Best Time to Buy and Sell Stock with Transaction Fee (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee)
// Date solved: 11/24/2024 4:26:56 AM +00:00
// Memory: 62.6 MB
// Runtime: 5 ms


public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        var n = prices.Length;
        var inStock = new int[n];
        var inCash = new int[n];
        for(var i=0; i<n; i++) {
            var p = prices[i];
            inStock[i] = i==0 ? -p : Math.Max(inCash[i-1]-p, inStock[i-1]);
            inCash[i] = i==0 ? 0 : Math.Max(inStock[i-1]+p-fee, inCash[i-1]);
        }
        return Math.Max(inCash[n-1], inStock[n-1]);
    }
}
