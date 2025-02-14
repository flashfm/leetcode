// Copyright (c) 2020 Alexey Filatov
// 121 - Best Time to Buy and Sell Stock (https://leetcode.com/problems/best-time-to-buy-and-sell-stock)
// Date solved: 3/16/2020 6:19:24 AM +00:00
// Memory: 25.3 MB
// Runtime: 96 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var minSoFar = int.MaxValue;
        var result = 0;
        for(var i = 0; i<prices.Length; i++) {
            var p = prices[i];
            if (p<minSoFar) {
                minSoFar = p;
            }
            else {
                var profit = p-minSoFar;
                if (profit>result) {
                    result = profit;
                }
            }
        }
        return result;
    }
}
