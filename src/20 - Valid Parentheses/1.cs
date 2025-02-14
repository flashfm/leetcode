// Copyright (c) 2020 Alexey Filatov
// 20 - Valid Parentheses (https://leetcode.com/problems/valid-parentheses)
// Date solved: 3/20/2020 7:33:01 AM +00:00
// Memory: 22.2 MB
// Runtime: 76 ms


public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(var c in s) {
            if (c=='(' || c=='[' || c=='{') {
                stack.Push(c);
            }
            else {
                if (stack.Count==0) return false;
                var e = c==')' ? '(' : c==']' ? '[' : c=='}' ? '{' : ' ';
                if (e!=stack.Pop()) return false;
            }
        }
        return stack.Count==0;
    }
}
