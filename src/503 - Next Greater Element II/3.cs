// Copyright (c) 2024 Alexey Filatov
// 503 - Next Greater Element II (https://leetcode.com/problems/next-greater-element-ii)
// Date solved: 12/1/2024 6:33:23 AM +00:00
// Memory: 59.5 MB
// Runtime: 6 ms


public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var stack = new Stack<(int Val, int Index)>();
        var n = nums.Length;
        var result = new int[n];
        Array.Fill(result, -1);
        for(var i = 0; i<n; i++) {
            var num = nums[i];
            while(stack.Count>0 && num>stack.Peek().Val) {
                result[stack.Pop().Index] = num;
            }
            stack.Push((num, i));
        }
        if (stack.Count>0) {
            for(var i = 0; i<n; i++) {
                var num = nums[i];
                while(stack.Count>0 && num>stack.Peek().Val) {
                    result[stack.Pop().Index] = num;
                }
            }
        }
        return result;
    }
}
