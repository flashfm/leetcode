// Copyright (c) 2024 Alexey Filatov
// 137 - Single Number II (https://leetcode.com/problems/single-number-ii)
// Date solved: 10/14/2024 10:19:52 PM +00:00
// Memory: 42.4 MB
// Runtime: 74 ms


public class Solution {
    public int SingleNumber(int[] nums) {
        var x1 = 0;
        var x2 = 0;
        foreach(var n in nums) {
            x2 ^= x1 & n;
            x1 ^= n;
            var mask = ~(x1 & x2);
            x2 &= mask;
            x1 &= mask;
        }
        return x1;
    }
}
