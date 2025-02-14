// Copyright (c) 2024 Alexey Filatov
// 1528 - Kids With the Greatest Number of Candies (https://leetcode.com/problems/kids-with-the-greatest-number-of-candies)
// Date solved: 10/27/2024 4:28:27 AM +00:00
// Memory: 48.3 MB
// Runtime: 3 ms


public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = candies.Max();
        var result = new bool[candies.Length];
        for(var i=0; i<candies.Length; i++) {
            result[i] = candies[i] + extraCandies >= max;
        }
        return result;
    }
}
