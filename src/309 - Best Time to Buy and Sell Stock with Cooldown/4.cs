// Copyright (c) 2020 Alexey Filatov
// 309 - Best Time to Buy and Sell Stock with Cooldown (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown)
// Date solved: 8/4/2020 6:32:12 AM +00:00
// Memory: 24.5 MB
// Runtime: 88 ms


// dp
// buy[i] - max profit for all the transactions when the last (at I or before) ends with "buy"
// sell[i] - max profit for all the transactions when the last (at I or before) ends with "sell"
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length==0) return 0;
        int bi = 0, si = 0, si1 = 0, si2 = 0;
        var bi2 = -prices[0];
        var bi1 = bi2;
        for(var i = 1; i<prices.Length; i++) {            
            bi = Math.Max(bi1, si2 - prices[i]);
            si = Math.Max(si1, bi1 + prices[i]);
            bi2 = bi1;
            si2 = si1;
            bi1 = bi;
            si1 = si;
        }
        return si1;
    }
}
