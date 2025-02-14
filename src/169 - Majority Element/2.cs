// Copyright (c) 2020 Alexey Filatov
// 169 - Majority Element (https://leetcode.com/problems/majority-element)
// Date solved: 1/16/2020 4:32:56 PM +00:00
// Memory: 30 MB
// Runtime: 108 ms


public class Solution {
    public int MajorityElement(int[] nums) {
        var c = 0;
        var result = 0;
        foreach(var n in nums) {
            if (c==0) result = n;
            c += n==result ? 1 : -1;
        }
        return result;
    }
}
