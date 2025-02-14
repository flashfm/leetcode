// Copyright (c) 2020 Alexey Filatov
// 122 - Best Time to Buy and Sell Stock II (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)
// Date solved: 3/7/2020 2:58:25 AM +00:00
// Memory: 25.3 MB
// Runtime: 96 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var needBuy = true;
        var buy = 0;
        var result = 0;
        for(var i = 1; i<prices.Length; i++) {
            if (prices[i]>prices[i-1]) {
                result += prices[i] - prices[i-1];
            }
        }
        return result;
    }
}
