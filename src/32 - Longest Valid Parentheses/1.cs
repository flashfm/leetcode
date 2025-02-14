// Copyright (c) 2024 Alexey Filatov
// 32 - Longest Valid Parentheses (https://leetcode.com/problems/longest-valid-parentheses)
// Date solved: 12/7/2024 5:34:22 AM +00:00
// Memory: 40.7 MB
// Runtime: 12 ms


public class Solution {
    public int LongestValidParentheses(string s) {
        var n = s.Length;
        var stack = new Stack<(char Val, int Pos)>();
        var valids = new bool[n];
        for(var i=0; i<n; i++) {
            var c = s[i];
            if (c==')' && stack.Count>0 && stack.Peek().Val=='(') {
                valids[i] = valids[stack.Pop().Pos] = true;
            }
            else {
                stack.Push((c, i));
            }            
        }
        var len = 0;
        var maxLen = 0;
        foreach(var v in valids) {
            if (v) {
                len++;
            }
            else {
                maxLen = Math.Max(maxLen, len);
                len = 0;
            }
        }
        return Math.Max(maxLen, len);
    }
}
