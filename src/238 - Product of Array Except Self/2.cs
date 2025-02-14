// Copyright (c) 2020 Alexey Filatov
// 238 - Product of Array Except Self (https://leetcode.com/problems/product-of-array-except-self)
// Date solved: 2/5/2020 8:39:11 AM +00:00
// Memory: 35.8 MB
// Runtime: 240 ms


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var stack = new int[nums.Length];
        stack[0]=1;
        for(var i=0;i<nums.Length-1;i++) {
            stack[i+1] = stack[i]*nums[i];
        }
        var x = 1;
        for(var i=nums.Length-1;i>=0;i--) {
            stack[i] = x * stack[i];
            x *= nums[i];
        }
        return stack; 
    }
}
