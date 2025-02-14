// Copyright (c) 2020 Alexey Filatov
// 461 - Hamming Distance (https://leetcode.com/problems/hamming-distance)
// Date solved: 3/16/2020 8:55:42 AM +00:00
// Memory: 14.5 MB
// Runtime: 36 ms


public class Solution {
    public int HammingDistance(int x, int y) {
        var xor = x^y;
        var result = 0;
        while(xor>0) {
            if ((xor & 1) == 1) result++;
            xor = xor >> 1;
        }
        return result;
    }
}
