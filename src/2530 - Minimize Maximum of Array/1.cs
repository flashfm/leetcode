// Copyright (c) 2024 Alexey Filatov
// 2530 - Minimize Maximum of Array (https://leetcode.com/problems/minimize-maximum-of-array)
// Date solved: 10/31/2024 4:11:23 AM +00:00
// Memory: 70.6 MB
// Runtime: 2 ms


public class Solution {
    public int MinimizeArrayValue(int[] nums) {
        long sum = 0;
        long result = 0;
        for(var i = 0; i<nums.Length; i++) {
            sum = nums[i] + (i==0 ? 0 : sum);
            var h = sum==0 ? 0 : (sum-1) / (i+1) + 1;
            result = Math.Max(result, h);
        }
        return (int)result;
    }
}
