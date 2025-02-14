// Copyright (c) 2024 Alexey Filatov
// 201 - Bitwise AND of Numbers Range (https://leetcode.com/problems/bitwise-and-of-numbers-range)
// Date solved: 10/15/2024 2:02:22 AM +00:00
// Memory: 27.2 MB
// Runtime: 31 ms


public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        var shift = 0;
        while(left!=right) {
            left >>= 1;
            right >>= 1;
            shift++;
        }
        return left << shift;
    }
}
