// Copyright (c) 2024 Alexey Filatov
// 53 - Maximum Subarray (https://leetcode.com/problems/maximum-subarray)
// Date solved: 10/29/2024 9:30:31 PM +00:00
// Memory: 62.7 MB
// Runtime: 1 ms


public class Solution {
    public int MaxSubArray(int[] nums) {
        var sum = 0;
        var result = nums.Length==0 ? 0 : int.MinValue;
        for(var i = 0; i<nums.Length; i++) {
            sum = nums[i] + (sum>0 ? sum : 0);
            result = Math.Max(result, sum);
        }
        return result;
    }
}
