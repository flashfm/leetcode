// Copyright (c) 2024 Alexey Filatov
// 560 - Subarray Sum Equals K (https://leetcode.com/problems/subarray-sum-equals-k)
// Date solved: 10/29/2024 2:50:55 AM +00:00
// Memory: 52.3 MB
// Runtime: 15 ms


public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var n = nums.Length;
        var prefixSum = new int[n];
        var countBySum = new Dictionary<int, int>();
        countBySum[0] = 1;
        var result = 0;
        for(var i = 0; i<n; i++) {
            var sum = prefixSum[i] = (i==0 ? 0 : prefixSum[i-1]) + nums[i];
            result += countBySum.GetValueOrDefault(sum - k);
            countBySum[sum] = countBySum.GetValueOrDefault(sum) + 1;
        }
        return result;
    }
}
