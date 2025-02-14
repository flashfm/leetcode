// Copyright (c) 2024 Alexey Filatov
// 581 - Shortest Unsorted Continuous Subarray (https://leetcode.com/problems/shortest-unsorted-continuous-subarray)
// Date solved: 10/22/2024 10:07:28 PM +00:00
// Memory: 49.7 MB
// Runtime: 6 ms


public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        var n = nums.Length;
        var copy = nums.ToArray();
        Array.Sort(copy);
        var s = 0;
        while(s < n && nums[s]==copy[s]) {
            s++;
        }
        var e = n-1;
        while(e>s && nums[e]==copy[e]) {
            e--;
        }
        return e-s+1;
    }
}
