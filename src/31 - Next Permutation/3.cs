// Copyright (c) 2024 Alexey Filatov
// 31 - Next Permutation (https://leetcode.com/problems/next-permutation)
// Date solved: 12/16/2024 10:49:49 PM +00:00
// Memory: 47.2 MB
// Runtime: 0 ms


public class Solution {
    public void NextPermutation(int[] nums) {
        var n = nums.Length;
        int k;
        for(k=n-2; k>=0; k--) {
            if (nums[k]<nums[k+1]) {
                break;
            }
        }
        if (k<0) {
            Array.Reverse(nums);
        }
        else {
            for(var l=n-1; l>k; l--) {
                if (nums[k]<nums[l]) {
                    (nums[k], nums[l]) = (nums[l], nums[k]);
                    Array.Reverse(nums, k+1, n-k-1);
                    return;
                }
            }
        }
    }
}
