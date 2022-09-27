// Maximum Subarray
// https://leetcode.com/problems/maximum-subarray
// Date solved: 04/09/2020 05:50:31 +00:00

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
