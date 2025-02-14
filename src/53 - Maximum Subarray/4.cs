// Copyright (c) 2024 Alexey Filatov
// 53 - Maximum Subarray (https://leetcode.com/problems/maximum-subarray)
// Date solved: 10/29/2024 9:25:46 PM +00:00
// Memory: 62.9 MB
// Runtime: 2 ms


public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length==0) {
            return 0;
        }
        var sum = 0;
        var result = int.MinValue;
        for(var i = 0; i<nums.Length; i++) {
            if (sum<=0) {
                sum = nums[i];
            }
            else {
                sum += nums[i];
            }
            result = Math.Max(result, sum);
        }
        return result;
    }
}
