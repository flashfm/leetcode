// Copyright (c) 2024 Alexey Filatov
// 954 - Maximum Sum Circular Subarray (https://leetcode.com/problems/maximum-sum-circular-subarray)
// Date solved: 10/10/2024 9:07:24 PM +00:00
// Memory: 51.5 MB
// Runtime: 187 ms


public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        if (nums==null || nums.Length==0) {
            return 0;
        }
        var curMax = -40000;
        var max = curMax;
        var curMin = 40000;
        var min = curMin;
        var total = 0;
        foreach(var n in nums) {
            curMax = Math.Max(curMax + n, n);
            max = Math.Max(max, curMax);
            curMin = Math.Min(curMin + n, n);
            min = Math.Min(min, curMin);
            total += n;
        }
        
        return max > 0 ? Math.Max(max, total - min) : max;
    }
}
