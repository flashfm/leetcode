// Copyright (c) 2024 Alexey Filatov
// 983 - Validate Stack Sequences (https://leetcode.com/problems/validate-stack-sequences)
// Date solved: 10/23/2024 2:48:56 AM +00:00
// Memory: 44.8 MB
// Runtime: 2 ms


public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var stack = new Stack<int>();
        var i = 0;
        foreach(var p in pushed) {
            stack.Push(p);
            while (stack.Count>0 && popped[i]==stack.Peek()) {
                stack.Pop();
                i++;
            }
        }
        return stack.Count==0;
    }
}
