// Copyright (c) 2020 Alexey Filatov
// 191 - Number of 1 Bits (https://leetcode.com/problems/number-of-1-bits)
// Date solved: 3/11/2020 7:14:35 AM +00:00
// Memory: 14.6 MB
// Runtime: 32 ms


public class Solution {
    public int HammingWeight(uint n) {
        uint result = 0;
        while(n>0) {
            result += n & 1;
            n = n >> 1;
        }
        return (int)result;
    }
}
