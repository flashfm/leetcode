// Copyright (c) 2024 Alexey Filatov
// 643 - Maximum Average Subarray I (https://leetcode.com/problems/maximum-average-subarray-i)
// Date solved: 11/10/2024 3:12:04 AM +00:00
// Memory: 58.6 MB
// Runtime: 2 ms


public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var sum = 0;
        for(var i = 0; i<k; i++) {
            sum += nums[i];
        }
        var max = sum;
        for(var i = k; i<nums.Length; i++) {
            sum = sum + nums[i] - nums[i-k];
            max = Math.Max(max, sum);
        }
        return (double)max/k;
    }
}
