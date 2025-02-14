// Copyright (c) 2024 Alexey Filatov
// 32 - Longest Valid Parentheses (https://leetcode.com/problems/longest-valid-parentheses)
// Date solved: 12/7/2024 5:44:36 AM +00:00
// Memory: 40.5 MB
// Runtime: 4 ms


public class Solution {
    public int LongestValidParentheses(string s) {
        var n = s.Length;
        var stack = new Stack<(char Val, int Pos)>();
        var lens = new int[n+1];
        var maxLen = 0;
        for(var i=0; i<n; i++) {
            var c = s[i];
            if (c==')' && stack.Count>0 && stack.Peek().Val=='(') {
                var pos = stack.Pop().Pos;
                lens[i+1] = lens[pos] + lens[i] + 2;
                maxLen = Math.Max(maxLen, lens[i+1]);
            }
            else {
                stack.Push((c, i));
            }            
        }
        return maxLen;
    }
}
