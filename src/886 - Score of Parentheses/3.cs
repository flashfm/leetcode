// Copyright (c) 2024 Alexey Filatov
// 886 - Score of Parentheses (https://leetcode.com/problems/score-of-parentheses)
// Date solved: 12/5/2024 5:27:55 AM +00:00
// Memory: 37.6 MB
// Runtime: 1 ms


public class Solution {
    public int ScoreOfParentheses(string s) {
        var stack = new Stack<int>();
        var score = 0;
        foreach(var c in s) {
            if (c=='(') {
                stack.Push(score);
                score = 0;
            }
            else {
                score = stack.Pop() + Math.Max(1, 2 * score);
            }
        }
        return score;
    }
}
