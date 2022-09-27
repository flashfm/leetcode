// Product of Array Except Self
// https://leetcode.com/problems/product-of-array-except-self
// Date solved: 02/05/2020 08:39:11 +00:00

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
