// Copyright (c) 2024 Alexey Filatov
// 1046 - Max Consecutive Ones III (https://leetcode.com/problems/max-consecutive-ones-iii)
// Date solved: 11/10/2024 4:07:40 AM +00:00
// Memory: 61.4 MB
// Runtime: 1 ms


public class Solution {
    public int LongestOnes(int[] nums, int k) {
        var l = 0;
        for(var r = 0; r<nums.Length; r++) {
            if (nums[r]==0) {
                k--;
            }
            if (k<0) {
                if (nums[l]==0) {
                    k++;
                }
                l++;
            }
        }
        return nums.Length - l;
    }
}
