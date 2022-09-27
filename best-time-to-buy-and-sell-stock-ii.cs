// Best Time to Buy and Sell Stock II
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
// Date solved: 04/09/2020 05:51:36 +00:00

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
