// Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock
// Date solved: 03/16/2020 06:19:24 +00:00

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
