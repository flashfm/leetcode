// Copyright (c) 2024 Alexey Filatov
// 334 - Increasing Triplet Subsequence (https://leetcode.com/problems/increasing-triplet-subsequence)
// Date solved: 11/9/2024 10:20:57 PM +00:00
// Memory: 86.7 MB
// Runtime: 3 ms


public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var i = 0;
        var j = -1;
        var candi = -1;
        for(var x = 0; x<nums.Length; x++) {
            if (j!=-1 && nums[j] < nums[x]) {
                return true;
            }

            if (j==-1 && nums[x] < nums[i]) {
                i = x;
                continue;
            }

            if (candi!=-1 && nums[x] > nums[candi] && j!=-1 && nums[x] <= nums[j]) {
                i = candi;
                j = x;
                candi = -1;
                continue;
            }

            if ((j==-1 && nums[i]<nums[x]) || (j!=-1 && nums[x]<nums[j] && nums[x]>nums[i])) {
                j = x;
                continue;
            }

            if (j!=-1 && nums[x] < nums[j] && nums[x] <= nums[i]) {
                candi = x;
                continue;
            }
        }
        return false;
    }
}
