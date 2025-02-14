// Copyright (c) 2024 Alexey Filatov
// 135 - Candy (https://leetcode.com/problems/candy)
// Date solved: 8/22/2024 12:54:16 AM +00:00
// Memory: 47 MB
// Runtime: 427 ms


public class Solution {
    public int Candy(int[] ratings) {
        var n = ratings.Length;
        var candies = new int[n];
        for(var i=0; i<n; i++) {
            Allocate(ratings, candies, i);
            //Console.WriteLine(string.Join(", ", candies));
        }
        return candies.Sum();
    }
    
    private void Allocate(int[] ratings, int[] candies, int i)
    {
        if (i==0 || ratings[i] == ratings[i-1]) {
            candies[i] = 1;
            return;
        }

        if (ratings[i] < ratings[i-1]) {
            candies[i] = candies[i-1]==1 ? 0 : 1;
        }
        else {
            candies[i] = candies[i-1] + 1;
        }

        if (candies[i] == 0) {
            candies[i] = 1;
            var j = i-1;
            while(j>=0 && ratings[j] > ratings[j+1] && candies[j] <= candies[j+1]) {
                candies[j]++;
                j--;
            }
        }
    }
}
