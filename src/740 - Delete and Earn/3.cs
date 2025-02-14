// Copyright (c) 2024 Alexey Filatov
// 740 - Delete and Earn (https://leetcode.com/problems/delete-and-earn)
// Date solved: 12/19/2024 2:48:15 AM +00:00
// Memory: 44.2 MB
// Runtime: 29 ms


public class Solution {
    public int DeleteAndEarn(int[] nums) {
        var n = nums.Length;
        var dict = new Dictionary<int, int>();
        foreach(var num in nums) {
            dict[num] = dict.GetValueOrDefault(num) + num;
        }
        var p2 = dict.GetValueOrDefault(0); // i-2
        var p1 = dict.GetValueOrDefault(1); // i-1
        for(var i=2; i<=10000; i++) {
            (p1, p2) = (Math.Max(p1, dict.GetValueOrDefault(i) + p2), p1);
        }
        return p1;
    }
}
