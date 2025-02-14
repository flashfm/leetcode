// Copyright (c) 2024 Alexey Filatov
// 560 - Subarray Sum Equals K (https://leetcode.com/problems/subarray-sum-equals-k)
// Date solved: 10/28/2024 2:16:03 AM +00:00
// Memory: 52 MB
// Runtime: 1554 ms


public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var n = nums.Length;
        var prefixSum = new int[n];
        prefixSum[0] = nums[0];
        for(var i = 1; i<n; i++) {
            prefixSum[i] = prefixSum[i-1] + nums[i];
        }
        var result = 0;
        for(var start = 0; start<n; start++) {
            for(var len=1; len<=n-start; len++) {
                var end = start+len-1;
                var sum = prefixSum[end] - (start<1 ? 0 : prefixSum[start-1]);
                if (sum==k) {
                    result++;
                }
            }
        }
        return result;
    }
}
