// Copyright (c) 2020 Alexey Filatov
// 53 - Maximum Subarray (https://leetcode.com/problems/maximum-subarray)
// Date solved: 4/9/2020 5:50:31 AM +00:00
// Memory: 25.3 MB
// Runtime: 88 ms


public class Solution {
    public int MaxSubArray(int[] nums) {
        var dp = new int[nums.Length];
        dp[0] = nums[0];
        var result = dp[0];                
        for(var i=1; i<nums.Length; i++) {
            dp[i] = nums[i] + (dp[i-1]>0 ? dp[i-1] : 0);
            if (dp[i]>result) {
                result = dp[i];
            }
        }
        return result;
    }
}
