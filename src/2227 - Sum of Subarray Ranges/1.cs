// Copyright (c) 2024 Alexey Filatov
// 2227 - Sum of Subarray Ranges (https://leetcode.com/problems/sum-of-subarray-ranges)
// Date solved: 10/22/2024 5:43:37 AM +00:00
// Memory: 42.7 MB
// Runtime: 42 ms


public class Solution {
    public long SubArrayRanges(int[] nums) {
        var n = nums.Length;
        var max = new int[n];
        var min = new int[n];
        long result = 0;
        for(var l = 1; l<=n; l++) {
            for(var s = 0; s<n-l+1; s++) {
                max[s] = l==1 ? nums[s+l-1] : Math.Max(max[s], nums[s+l-1]);
                min[s] = l==1 ? nums[s+l-1] : Math.Min(min[s], nums[s+l-1]);
                result += max[s] - min[s];
            }
        }
        return result;
    }
}
