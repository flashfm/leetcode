// Copyright (c) 2020 Alexey Filatov
// 169 - Majority Element (https://leetcode.com/problems/majority-element)
// Date solved: 1/16/2020 4:21:16 PM +00:00
// Memory: 29.6 MB
// Runtime: 108 ms


public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var n in nums) dict[n] = dict.TryGetValue(n, out var o) ? o + 1 : 1;
        var n2 = nums.Length/2;
        foreach(var (n, c) in dict) if (c>n2) return n;
        return 0;
    }
}
