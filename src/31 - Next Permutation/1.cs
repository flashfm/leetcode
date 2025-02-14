// Copyright (c) 2024 Alexey Filatov
// 31 - Next Permutation (https://leetcode.com/problems/next-permutation)
// Date solved: 12/11/2024 5:35:12 AM +00:00
// Memory: 46.9 MB
// Runtime: 2 ms


public class Solution {
    public void NextPermutation(int[] nums) {
        var n = nums.Length;
        for(var l=n-1; l>=0; l--) {
            var minR = -1;
            var min = int.MaxValue;
            for(var r=l+1;r<n;r++) {
                if (nums[r]>nums[l] && nums[r]<min) {
                    min = nums[r];
                    minR = r;
                }
            }
            if (minR!=-1) {
                // swap
                (nums[minR], nums[l]) = (nums[l], nums[minR]);
                //Console.WriteLine(string.Join(",", nums));
                Array.Sort(nums, l+1, n-l-1);
                return;
            }
        }
        Array.Sort(nums);
    }
}
