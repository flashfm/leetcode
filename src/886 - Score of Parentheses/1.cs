// Copyright (c) 2024 Alexey Filatov
// 886 - Score of Parentheses (https://leetcode.com/problems/score-of-parentheses)
// Date solved: 12/5/2024 5:12:22 AM +00:00
// Memory: 37.5 MB
// Runtime: 0 ms


public class Solution {
    public int ScoreOfParentheses(string s) {
        return Score(s, 0, s.Length-1);
    }

    private int Score(string s, int start, int end)
    {
        if (end-start==1 && s[start]=='(' && s[end]==')') {
            return 1;
        }
        if (s[start]!='(') {
            return 0;
        }
        var i = start+1;
        var count = 1;
        while(i<=end) {
            if (s[i]=='(') {
                count++;
            }
            else {
                count--;
            }
            if (count==0) {
                break;
            }
            i++;
        }
        if (i==end) {
            return 2 * Score(s, start+1, end-1);
        }
        else {
            return Score(s, start, i) + Score(s, i+1, end);
        }
    }
}
