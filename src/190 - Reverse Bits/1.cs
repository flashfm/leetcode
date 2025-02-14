// Copyright (c) 2020 Alexey Filatov
// 190 - Reverse Bits (https://leetcode.com/problems/reverse-bits)
// Date solved: 3/17/2020 3:08:22 AM +00:00
// Memory: 15 MB
// Runtime: 40 ms


public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        uint mask = ((uint)1) << 31;
        while(n>0) {
            if ((n & 1)==1) {
                result |= mask;
            }
            n = n >> 1;
            mask = mask >> 1;
        }
        return result;
    }
}
