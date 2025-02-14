// Copyright (c) 2024 Alexey Filatov
// 907 - Koko Eating Bananas (https://leetcode.com/problems/koko-eating-bananas)
// Date solved: 10/25/2024 12:03:30 AM +00:00
// Memory: 48.5 MB
// Runtime: 11 ms


public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var l = 1;
        var r = piles.Max();
        while(l<r) {
            var m = (l+r)/2;         
            // calculate hours
            var hours = 0;
            foreach(var p in piles) {
                hours += (p-1) / m + 1;
            }
            if (hours<=h) {
                r = m;
            }
            else {
                l = m+1;
            }
        }
        return l;
    }
}
