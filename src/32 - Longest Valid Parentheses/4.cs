// Copyright (c) 2024 Alexey Filatov
// 32 - Longest Valid Parentheses (https://leetcode.com/problems/longest-valid-parentheses)
// Date solved: 12/7/2024 5:58:14 AM +00:00
// Memory: 39.9 MB
// Runtime: 3 ms


public class Solution {
    public int LongestValidParentheses(string s) {
        var n = s.Length;
        var stack = new Stack<int>();
        var maxLen = 0;
        var leftClosing = -1;
        for(var i=0; i<n; i++) {
            if (s[i]=='(') {
                stack.Push(i);
            }
            else if (stack.Count>0) {
                stack.Pop();
                maxLen = Math.Max(maxLen, i - (stack.Count>0 ? stack.Peek() : leftClosing));
            }
            else {
                leftClosing = i;
            }
        }
        return maxLen;
    }
}
