// Copyright (c) 2024 Alexey Filatov
// 152 - Maximum Product Subarray (https://leetcode.com/problems/maximum-product-subarray)
// Date solved: 11/8/2024 2:06:26 AM +00:00
// Memory: 43 MB
// Runtime: 1 ms


public class Solution {
    public int MaxProduct(int[] nums) {
        var result = int.MinValue;
        var pos = 0;
        var neg = 0;
        for(var i = 0; i<nums.Length; i++) {
            var x = nums[i];
            if (x>0) {
                pos = Math.Max(pos, 1) * x;
                neg *= x;
            }
            else if (x<0) {
                var oldNeg = neg;
                neg = Math.Max(pos, 1) * x;
                pos = oldNeg * x;
            }
            else {
                result = Math.Max(result, 0);
                pos = neg = 0;
            }
            if (pos!=0) {
                result = Math.Max(result, pos);
            }
            if (neg!=0) {
                result = Math.Max(result, neg);
            }
        }
        return result;
    }
}
