// Valid Parentheses
// https://leetcode.com/problems/valid-parentheses
// Date solved: 03/20/2020 07:33:01 +00:00

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
