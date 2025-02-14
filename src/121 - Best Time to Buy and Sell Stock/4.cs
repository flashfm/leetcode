// Copyright (c) 2024 Alexey Filatov
// 121 - Best Time to Buy and Sell Stock (https://leetcode.com/problems/best-time-to-buy-and-sell-stock)
// Date solved: 10/17/2024 5:29:50 AM +00:00
// Memory: 57.5 MB
// Runtime: 340 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        if (n==0) {
            return 0;
        }
        var one = new int[n];
        var min = prices[0];
        for(var i=1; i<n; i++) {
            one[i] = Math.Max(one[i-1], prices[i] - min);
            min = Math.Min(min, prices[i]);
        }
        return one[n-1];
    }
}
