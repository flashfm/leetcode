// Copyright (c) 2020 Alexey Filatov
// 122 - Best Time to Buy and Sell Stock II (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii)
// Date solved: 3/7/2020 2:52:29 AM +00:00
// Memory: 25.3 MB
// Runtime: 92 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var needBuy = true;
        var buy = 0;
        var result = 0;
        for(var i = 1; i<prices.Length; i++) {
            if (prices[i]>prices[i-1]) {
                if (needBuy) {
                    needBuy = false;
                    buy = prices[i-1];
                }
            }
            else {
                if (!needBuy) {
                    result += prices[i-1] - buy;
                    needBuy = true;
                }
            }
        }
        if (!needBuy) result += prices[prices.Length-1] - buy;
        return result;
    }
}
