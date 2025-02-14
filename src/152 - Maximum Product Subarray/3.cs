// Copyright (c) 2024 Alexey Filatov
// 152 - Maximum Product Subarray (https://leetcode.com/problems/maximum-product-subarray)
// Date solved: 11/8/2024 2:03:12 AM +00:00
// Memory: 42.8 MB
// Runtime: 1 ms


public class Solution {
    public int MaxProduct(int[] nums) {
        var result = int.MinValue;
        int? pos = null;
        int? neg = null;
        for(var i = 0; i<nums.Length; i++) {
            var x = nums[i];
            if (x>0) {
                pos = (pos ?? 1) * x;
                neg *= x;
            }
            else if (x<0) {
                var oldNeg = neg;
                neg = (pos ?? 1) * x;
                pos = oldNeg==null ? null : oldNeg * x;
            }
            else {
                result = Math.Max(result, 0);
                pos = neg = null;
            }
            result = Math.Max(result, Math.Max(neg ?? int.MinValue, pos ?? int.MinValue));
        }
        return result;
    }
}
