// Copyright (c) 2020 Alexey Filatov
// 342 - Power of Four (https://leetcode.com/problems/power-of-four)
// Date solved: 8/5/2020 6:24:22 AM +00:00
// Memory: 14.6 MB
// Runtime: 80 ms


public class Solution {
    public bool IsPowerOfFour(int num) {
        // 100
        // 10000
        //...
        // num-1
        // 011
        // 01111
        // 0101 = 0x5
        // 0101 0101 = 0x55
        // 32bit = 8 times of 5 
        return num>0 && (num&(num-1))==0 && (num & 0x55555555)!=0;
    }
}
