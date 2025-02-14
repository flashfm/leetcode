// Copyright (c) 2024 Alexey Filatov
// 153 - Find Minimum in Rotated Sorted Array (https://leetcode.com/problems/find-minimum-in-rotated-sorted-array)
// Date solved: 10/11/2024 12:05:40 AM +00:00
// Memory: 41.1 MB
// Runtime: 65 ms


public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length-1;
        var m = 0;
        var min = nums[0];
        while(l<r) {
            m = l + (r-l)/2;
            if (nums[m] < nums[r]) {
                min = Math.Min(min, nums[m]);
                r = m;
            }
            else {
                min = Math.Min(min, nums[r]);
                l = m+1;
            }
        }
        return min;
    }
}
