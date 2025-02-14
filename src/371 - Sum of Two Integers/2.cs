// Copyright (c) 2020 Alexey Filatov
// 371 - Sum of Two Integers (https://leetcode.com/problems/sum-of-two-integers)
// Date solved: 1/16/2020 8:44:35 AM +00:00
// Memory: 14.7 MB
// Runtime: 44 ms


public class Solution {
    public int GetSum(int a, int b) {
        if (b==0) return a;
        var carry = (a & b) << 1;
        var sumWoCarry = a ^ b;
        return GetSum(sumWoCarry, carry);
    }
}
