// Copyright (c) 2024 Alexey Filatov
// 20 - Valid Parentheses (https://leetcode.com/problems/valid-parentheses)
// Date solved: 10/30/2024 3:09:15 AM +00:00
// Memory: 40.7 MB
// Runtime: 1 ms


public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(var c in s) {
            switch(c) {
                case '(':
                case '{':
                case '[':
                    stack.Push(c);
                    break;
                case ')':
                    if (stack.Count==0 || stack.Pop()!='(') {
                        return false;
                    }
                    break;
                case '}':
                    if (stack.Count==0 || stack.Pop()!='{') {
                        return false;
                    }
                    break;
                case ']':
                    if (stack.Count==0 || stack.Pop()!='[') {
                        return false;
                    }
                    break;
            }
        }
        return stack.Count==0;
    }
}
