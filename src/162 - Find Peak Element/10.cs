// Copyright (c) 2020 Alexey Filatov
// 162 - Find Peak Element (https://leetcode.com/problems/find-peak-element)
// Date solved: 1/31/2020 7:09:43 AM +00:00
// Memory: 24.5 MB
// Runtime: 92 ms


public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0, r = nums.Length-1;
        while(l<r) {
            if (nums[l]>nums[l+1]) break;
            if (nums[r-1]<nums[r]) return r;
            var m = (l + r) / 2;        
            if (nums[r]>=nums[m] || nums[m-1]<nums[m]) l = m; else r = m;
        }
        return l;
    }
}
