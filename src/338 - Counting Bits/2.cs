// Copyright (c) 2024 Alexey Filatov
// 338 - Counting Bits (https://leetcode.com/problems/counting-bits)
// Date solved: 11/24/2024 7:48:23 AM +00:00
// Memory: 41.9 MB
// Runtime: 2 ms


public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n+1];
        var pow = 1;
        for(var i = 1; i<=n; i++) {
            if (i==pow*2) {
                pow *= 2;
            }
            result[i] = 1 + result[i-pow];
        }
        return result;
    }
}
