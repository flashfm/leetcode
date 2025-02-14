// Copyright (c) 2024 Alexey Filatov
// 152 - Maximum Product Subarray (https://leetcode.com/problems/maximum-product-subarray)
// Date solved: 11/8/2024 2:27:52 AM +00:00
// Memory: 42.8 MB
// Runtime: 0 ms


public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length==0) {
            return 0;
        }
        var max = nums[0];
        var min = nums[0];
        var result = max;
        for(var i = 1; i<nums.Length; i++) {
            var x = nums[i];
            if (x<0) {
                (min, max) = (max, min);
            }
            max = Math.Max(x, max * x);
            min = Math.Min(x, min * x);
            result = Math.Max(result, max);
        }
        return result;
    }
}
