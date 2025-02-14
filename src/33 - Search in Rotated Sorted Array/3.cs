// Copyright (c) 2024 Alexey Filatov
// 33 - Search in Rotated Sorted Array (https://leetcode.com/problems/search-in-rotated-sorted-array)
// Date solved: 10/23/2024 2:30:47 AM +00:00
// Memory: 41.2 MB
// Runtime: 0 ms


public class Solution {
    public int Search(int[] nums, int target) {
        var n = nums.Length;
        var l = 0;
        var r = n-1;
        while(l<=r) {
            var m = l + (r-l)/2;
            if (nums[m]==target) {
                return m;
            }
            if (nums[r]>nums[l]) {
                // regular case
                if (nums[m]>target) {
                    r = m-1;
                }
                else {
                    l = m+1;
                }
            }
            else if (nums[m]>nums[r]) {
                // array on the right is broken
                if (target>nums[m] || target<nums[l]) {
                    l = m+1;
                }
                else {
                    r = m-1;
                }
            }
            else {
                // array on the right is not broken
                if (target>nums[m] && target<=nums[r]) {
                    l = m+1;
                }
                else {
                    r = m-1;
                }
            }
        }
        return -1;
    }
}
