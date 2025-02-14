// Copyright (c) 2024 Alexey Filatov
// 32 - Longest Valid Parentheses (https://leetcode.com/problems/longest-valid-parentheses)
// Date solved: 12/7/2024 6:05:38 AM +00:00
// Memory: 40.1 MB
// Runtime: 2 ms


public class Solution {
    public int LongestValidParentheses(string s) {
        var n = s.Length;
        var longest = new int[n];
        var max = 0;
        for(var i=0; i<n; i++) {
            longest[i] = s[i]=='(' ? 0 :
                i-1>=0 && s[i-1]=='(' ? (i-2>0 ? longest[i-2] : 0) + 2 :
                i-1>=0 && i-longest[i-1]-1>=0 && s[i-longest[i-1]-1]=='(' ? longest[i-1] + (i-longest[i-1]-2>=0 ? longest[i-longest[i-1]-2] : 0) + 2 :
                0;
            max = Math.Max(max, longest[i]);
        }
        return max;
    }
}
