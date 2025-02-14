// Copyright (c) 2024 Alexey Filatov
// 123 - Best Time to Buy and Sell Stock III (https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii)
// Date solved: 10/17/2024 5:42:37 AM +00:00
// Memory: 70.3 MB
// Runtime: 339 ms


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

        var two = new int[n];
        var max = int.MinValue;
        for(var i=2; i<n; i++) {
            max = Math.Max(max, one[i-2] - prices[i-1]);
            two[i] = Math.Max(0, prices[i] + max);
        }
        //Console.WriteLine(string.Join(", ", one));
        //Console.WriteLine(string.Join(", ", two));
        return Math.Max(one[n-1], two.Max());
    }
}
