// Copyright (c) 2024 Alexey Filatov
// 123 - Best Time to Buy and Sell Stock III (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii)
// Date solved: 10/17/2024 5:59:45 AM +00:00
// Memory: 60.2 MB
// Runtime: 316 ms


public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        if (n<2) {
            return 0;
        }
        var min = Math.Min(prices[0], prices[1]);
        var one2 = 0;
        var one1 = prices[1] - prices[0];
        var one = one1;
        var max = int.MinValue;
        var two = 0; // profit if we sell two times and the second time is on day I
        for(var i=2; i<n; i++) {

            one = Math.Max(one1, prices[i] - min);
            min = Math.Min(min, prices[i]);

            max = Math.Max(max, one2 - prices[i-1]);
            two = Math.Max(two, prices[i] + max);

            one2 = one1;
            one1 = one;
        }
        return Math.Max(one, two);
    }
}
