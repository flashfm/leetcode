// Copyright (c) 2024 Alexey Filatov
// 739 - Daily Temperatures (https://leetcode.com/problems/daily-temperatures)
// Date solved: 11/28/2024 8:53:04 PM +00:00
// Memory: 66.6 MB
// Runtime: 12 ms


public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        var result = new int[n];
        var stack = new Stack<(int Val, int Pos)>();
        for(var i = n-1; i>=0; i--) {
            var t = temperatures[i];
            while(stack.Count>0 && stack.Peek().Val<=t) {
                stack.Pop();
            }
            var prevPos = stack.Count==0 ? i : stack.Peek().Pos;
            stack.Push((t, i));
            result[i] = prevPos - i;
        }
        return result;
    }
}
