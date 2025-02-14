// Copyright (c) 2024 Alexey Filatov
// 1586 - Longest Subarray of 1's After Deleting One Element (https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element)
// Date solved: 11/10/2024 4:08:12 AM +00:00
// Memory: 54 MB
// Runtime: 1 ms


public class Solution {
    public int LongestSubarray(int[] nums) {
        var l = 0;
        var k = 1;
        for(var r = 0; r<nums.Length; r++) {
            if (nums[r]==0) {
                k--;
            }
            if (k<0) {
                // we've just eaten second 0, current subarray size is the max so far, keep it
                if (nums[l]==0) {
                    k++;
                }
                l++; 
            }
        }
        return nums.Length - l-1;
    }
}
