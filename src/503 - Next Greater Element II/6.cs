// Copyright (c) 2024 Alexey Filatov
// 503 - Next Greater Element II (https://leetcode.com/problems/next-greater-element-ii)
// Date solved: 12/1/2024 6:36:13 AM +00:00
// Memory: 59.9 MB
// Runtime: 5 ms


public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var stack = new Stack<int>(); // indexes
        var n = nums.Length;
        var result = new int[n];
        Array.Fill(result, -1);
        for(var i = 0; i<n*2; i++) {
            var num = nums[i % n];
            while(stack.Count>0 && num>nums[stack.Peek()]) {
                result[stack.Pop()] = num;
            }
            if (i<n) {
                stack.Push(i % n);
            }
        }
        return result;
    }
}
