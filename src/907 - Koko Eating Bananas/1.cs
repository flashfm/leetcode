// Copyright (c) 2024 Alexey Filatov
// 907 - Koko Eating Bananas (https://leetcode.com/problems/koko-eating-bananas)
// Date solved: 10/24/2024 11:25:43 PM +00:00
// Memory: 48.8 MB
// Runtime: 10 ms


public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var l = 1;
        var r = piles.Max();
        while(l<=r) {
            var m = (l+r)/2;         
            // calculate hours
            double hours = 0;
            foreach(var p in piles) {
                hours += Math.Ceiling((double)p/m);
            }
            //Console.WriteLine($"l={l}, r={r}, m={m}, h={hours}");
            if (hours<=h) {
                r = (int)m-1;
            }
            else {
                l = (int)m+1;
            }
        }
        return l;
    }
}
