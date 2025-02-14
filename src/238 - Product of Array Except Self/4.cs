// Copyright (c) 2024 Alexey Filatov
// 238 - Product of Array Except Self (https://leetcode.com/problems/product-of-array-except-self)
// Date solved: 11/7/2024 11:26:22 PM +00:00
// Memory: 66 MB
// Runtime: 1 ms


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var p = 1;
        var zero = false;
        foreach(var num in nums) {
            if (num==0 && !zero) {
                zero = true;
            }
            else {
                p *= num;
            }
        }
        var result = new int[nums.Length];
        for(var i = 0; i<nums.Length; i++) {
            result[i] = zero && nums[i]!=0 ? 0 : p / (nums[i]==0 ? 1 : nums[i]);
        }
        return result;
    }
}
