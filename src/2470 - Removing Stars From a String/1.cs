// Copyright (c) 2024 Alexey Filatov
// 2470 - Removing Stars From a String (https://leetcode.com/problems/removing-stars-from-a-string)
// Date solved: 11/11/2024 9:20:44 PM +00:00
// Memory: 53.7 MB
// Runtime: 15 ms


public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        foreach(var c in s) {
            if (c=='*') {
                stack.Pop();
            }
            else {
                stack.Push(c);
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}
