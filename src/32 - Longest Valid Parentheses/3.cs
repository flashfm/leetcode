// Copyright (c) 2024 Alexey Filatov
// 32 - Longest Valid Parentheses (https://leetcode.com/problems/longest-valid-parentheses)
// Date solved: 12/7/2024 5:50:00 AM +00:00
// Memory: 40.3 MB
// Runtime: 3 ms


public class Solution {
    public int LongestValidParentheses(string s) {
        var n = s.Length;
        var stack = new Stack<int>();
        var lens = new int[n+1];
        var maxLen = 0;
        for(var i=0; i<n; i++) {
            if (s[i]=='(') {
                stack.Push(i);
            }
            else if (stack.Count>0) {
                var pos = stack.Pop();
                lens[i+1] = lens[pos] + lens[i] + 2;
                maxLen = Math.Max(maxLen, lens[i+1]);
            }
        }
        return maxLen;
    }
}
