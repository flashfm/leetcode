// Copyright (c) 2024 Alexey Filatov
// 1791 - Richest Customer Wealth (https://leetcode.com/problems/richest-customer-wealth)
// Date solved: 12/18/2024 2:40:23 AM +00:00
// Memory: 42 MB
// Runtime: 3 ms


public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var max = 0;
        foreach(var cust in accounts) {
            max = Math.Max(max, cust.Sum());
        }
        return max;
    }
}
