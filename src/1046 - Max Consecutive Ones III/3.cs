// Copyright (c) 2024 Alexey Filatov
// 1046 - Max Consecutive Ones III (https://leetcode.com/problems/max-consecutive-ones-iii)
// Date solved: 11/10/2024 3:51:39 AM +00:00
// Memory: 61 MB
// Runtime: 2 ms


public class Solution {
    public int LongestOnes(int[] nums, int k) {
        var n = nums.Length;
        var result = 0;
        var flipped = 0;
        var l = 0;
        var r = 0;
        // grow 1s or flip
        while(r<n) {
            while(r<n && (nums[r]==1 || flipped<k)) {
                result = Math.Max(result, r-l+1);
                if (nums[r]!=1) {
                    flipped++;
                }
                r++;
            }
            // can't grow or flip, move l
            while (l<=r && flipped==k) {
                if (l<n && nums[l]==0 && flipped>0) {
                    flipped--;
                }
                l++;
            }
            if (l>=r) {
                r++;
            }
        }
        return result;
    }
}
