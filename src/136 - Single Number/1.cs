// Copyright (c) 2020 Alexey Filatov
// 136 - Single Number (https://leetcode.com/problems/single-number)
// Date solved: 3/19/2020 5:20:33 AM +00:00
// Memory: 26.3 MB
// Runtime: 100 ms


public class Solution {
    public int SingleNumber(int[] nums) {
        var r = 0;
        foreach(var n in nums) r ^= n;
        return r;
    }
}
