// Copyright (c) 2020 Alexey Filatov
// 162 - Find Peak Element (https://leetcode.com/problems/find-peak-element)
// Date solved: 1/31/2020 7:44:19 AM +00:00
// Memory: 24.7 MB
// Runtime: 96 ms


public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0, r = nums.Length-1;
        while(l<r) {
            var m = (l + r) / 2;        
            if (nums[m+1]<nums[m]) r = m; else l = m+1;
        }
        return l;
    }
}
