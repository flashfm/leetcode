// Copyright (c) 2024 Alexey Filatov
// 238 - Product of Array Except Self (https://leetcode.com/problems/product-of-array-except-self)
// Date solved: 11/7/2024 11:23:46 PM +00:00
// Memory: 65.6 MB
// Runtime: 1 ms


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var p = 1;
        var magic = 31;
        var zero = false;
        var twoZeros = false;
        foreach(var num in nums) {
            if (num==0) {
                if (zero) {
                    twoZeros = true;
                }
                zero = true;
            }
            p *= num==0 ? magic : num;
        }
        var result = new int[nums.Length];
        if (twoZeros) {
            return result;
        }
        for(var i = 0; i<nums.Length; i++) {
            result[i] = zero && nums[i]!=0 ? 0 : p / (nums[i]==0 ? magic : nums[i]);
        }
        return result;
    }
}
