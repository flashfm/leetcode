// Copyright (c) 2024 Alexey Filatov
// 334 - Increasing Triplet Subsequence (https://leetcode.com/problems/increasing-triplet-subsequence)
// Date solved: 11/9/2024 10:27:34 PM +00:00
// Memory: 87 MB
// Runtime: 1 ms


public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var i = 0;
        var j = -1;
        var candi = -1;
        for(var x = 0; x<nums.Length; x++) {
            if (j==-1) {
                if (nums[x] < nums[i]) {
                    i = x;
                }
                else if (nums[x] > nums[i]) {
                    j = x;
                }
            }
            else {
                if (nums[x] > nums[j]) {
                    return true;
                }
                else if (nums[x]<=nums[j]) {
                    if (candi!=-1 && nums[x] > nums[candi]) {
                        i = candi;
                        j = x;
                        candi = -1;
                    }
                    else if (nums[x]>nums[i]) {
                        j = x;
                    }
                    else {
                        candi = x;
                    }
                }
            }
        }
        return false;
    }
}
