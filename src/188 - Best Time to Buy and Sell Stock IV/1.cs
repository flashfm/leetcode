// Copyright (c) 2024 Alexey Filatov
// 188 - Best Time to Buy and Sell Stock IV (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv)
// Date solved: 10/17/2024 6:16:13 AM +00:00
// Memory: 42.2 MB
// Runtime: 67 ms


public class Solution {
    public int MaxProfit(int k, int[] prices) {
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
        var result = one[n-1];

        for(var j = 0; j<k-1; j++) {
            var two = new int[n];
            var max = int.MinValue;
            for(var i=2; i<n; i++) {
                max = Math.Max(max, one[i-2] - prices[i-1]);
                two[i] = Math.Max(two[i-1], prices[i] + max);
                result = Math.Max(result, two[i]);
            }
            one = two;
        }
        return result;
    }
}
