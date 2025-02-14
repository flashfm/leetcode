// Copyright (c) 2024 Alexey Filatov
// 121 - Best Time to Buy and Sell Stock (https://leetcode.com/problems/best-time-to-buy-and-sell-stock)
// Date solved: 10/16/2024 9:23:30 PM +00:00
// Memory: 57.7 MB
// Runtime: 338 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var min = int.MaxValue;
        var profit = 0;
        foreach(var p in prices) {
            min = Math.Min(min, p);
            profit = Math.Max(profit, p-min);
        }
        return profit;
    }
}
