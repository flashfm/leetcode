// Copyright (c) 2024 Alexey Filatov
// 2552 - Maximum Sum of Distinct Subarrays With Length K (https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k)
// Date solved: 10/28/2024 1:12:43 AM +00:00
// Memory: 70.9 MB
// Runtime: 23 ms


public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        long sum = 0;
        long result = 0;
        for(var i=0; i<nums.Length; i++) {
            if (i>=k) {
                var j = nums[i-k];
                sum -= j;
                dict[j]--;
                if (dict[j]==0) {
                    dict.Remove(j);
                }
            }
            var n = nums[i];
            sum += n;
            dict[n] = dict.GetValueOrDefault(n) + 1;
            if (dict.Count==k) {
                result = Math.Max(result, sum);
            }
        }
        return result;
    }
}
