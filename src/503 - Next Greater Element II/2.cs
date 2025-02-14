// Copyright (c) 2024 Alexey Filatov
// 503 - Next Greater Element II (https://leetcode.com/problems/next-greater-element-ii)
// Date solved: 12/1/2024 6:31:33 AM +00:00
// Memory: 59.7 MB
// Runtime: 5 ms


public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var stack = new Stack<(int Val, int Index)>();
        var n = nums.Length;
        var result = new int[n];
        Array.Fill(result, -1);
        for(var i = 0; i<n*2; i++) {
            var num = nums[i%n];
            while(stack.Count>0 && num>stack.Peek().Val) {
                result[stack.Pop().Index] = num;
            }
            if (i<n) {
                stack.Push((num, i));
            }
            else if (stack.Count==0) {
                break;
            }
        }
        return result;
    }
}
