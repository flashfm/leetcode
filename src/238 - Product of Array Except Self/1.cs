// Copyright (c) 2020 Alexey Filatov
// 238 - Product of Array Except Self (https://leetcode.com/problems/product-of-array-except-self)
// Date solved: 2/5/2020 8:32:42 AM +00:00
// Memory: 37 MB
// Runtime: 276 ms


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new Stack<int>();
        var stack = new Stack<int>();
        stack.Push(1);
        for(var i=0;i<nums.Length-1;i++) {
            stack.Push(stack.Peek()*nums[i]);
        }
        var x = 1;
        for(var i=nums.Length-1;i>=0;i--) {
            result.Push(x * stack.Pop());
            x *= nums[i];
        }
        return result.ToArray(); 
    }
}
