// Copyright (c) 2024 Alexey Filatov
// 201 - Bitwise AND of Numbers Range (https://leetcode.com/problems/bitwise-and-of-numbers-range)
// Date solved: 10/15/2024 1:54:12 AM +00:00
// Memory: 27.5 MB
// Runtime: 25 ms


public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        var result = 0;
        for(var i = 0; i<32; i++) {
            var mask = 1 << i;
            if (mask>right) {
                break;
            }
            if ((right & mask) != 0 && (left & mask) != 0 && right-left < mask) {
                result += mask;
            }
        }
        return result;
    }
}
