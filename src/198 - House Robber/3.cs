// Copyright (c) 2024 Alexey Filatov
// 198 - House Robber (https://leetcode.com/problems/house-robber)
// Date solved: 11/23/2024 7:46:31 PM +00:00
// Memory: 39.9 MB
// Runtime: 0 ms


public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;
        var dp = new int[n];
        for(var i = 0; i<n; i++) {
            dp[i] = i==0 ? nums[0] : Math.Max(dp[i-1], nums[i] + (i==1 ? 0 : dp[i-2]));
        }
        return dp[n-1];
    }
}
