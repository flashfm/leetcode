// Copyright (c) 2024 Alexey Filatov
// 135 - Candy (https://leetcode.com/problems/candy)
// Date solved: 8/22/2024 1:28:31 AM +00:00
// Memory: 46.9 MB
// Runtime: 98 ms


public class Solution {
    public int Candy(int[] ratings) {
        var n = ratings.Length;
        var candies = new int[n];

        // forward pass
        for(var i=1; i<n; i++) {
            if (ratings[i] > ratings[i-1]) {
                candies[i] = candies[i-1] + 1;
            }
        }

        // back pass
        for(var i=n-2; i>=0; i--) {
            if (ratings[i] > ratings[i+1]) {
                candies[i] = Math.Max(candies[i], candies[i+1] + 1);
            }
        }

        return candies.Sum() + candies.Length;
    }
}
