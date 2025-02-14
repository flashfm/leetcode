// Copyright (c) 2024 Alexey Filatov
// 581 - Shortest Unsorted Continuous Subarray (https://leetcode.com/problems/shortest-unsorted-continuous-subarray)
// Date solved: 10/22/2024 11:06:39 PM +00:00
// Memory: 48.5 MB
// Runtime: 2 ms


public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        var n = nums.Length;
        var max = int.MinValue;
        var min = int.MaxValue;
        var e = 0;
        var s = 0;
        for(var i = 0; i<n; i++) {
            max = Math.Max(max, nums[i]);
            if (nums[i]<max) {
                e = i;
            }
            var j = n-i-1;
            min = Math.Min(min, nums[j]);
            if (nums[j]>min) {
                s = j;
            }
        }
        return e>s ? e-s+1 : 0;
    }
}
