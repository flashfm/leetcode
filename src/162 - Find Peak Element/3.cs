// Copyright (c) 2020 Alexey Filatov
// 162 - Find Peak Element (https://leetcode.com/problems/find-peak-element)
// Date solved: 1/31/2020 7:03:43 AM +00:00
// Memory: 24.9 MB
// Runtime: 88 ms


public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length==0) return 0;
                
        int l = 0, r = nums.Length-1;

        while(true) {
            if (l==r) return l;
            if (nums[l]>nums[l+1]) return l;
            if (nums[r-1]<nums[r]) return r;

            var m = (l + r) / 2;
            
            if (nums[m]>nums[m-1] && nums[m]>nums[m+1]) return m;
            
            if (nums[l]>=nums[m]) {
                r = m; // go left
            }
            else if (nums[r]>=nums[m]) {
                l = m; // go right
            }
            else if (nums[m-1]<nums[m]) {
                l = m; // go right
            }
            else {
                r = m; // go left
            }
        }
    }
}
