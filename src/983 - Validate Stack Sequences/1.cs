// Copyright (c) 2024 Alexey Filatov
// 983 - Validate Stack Sequences (https://leetcode.com/problems/validate-stack-sequences)
// Date solved: 10/23/2024 2:43:51 AM +00:00
// Memory: 44.8 MB
// Runtime: 2 ms


public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var stack = new Stack<int>();
        var added = new bool[1001];
        var i = 0;
        foreach(var p in popped) {
            while (i<pushed.Length && !added[p]) {
                var x = pushed[i++];
                stack.Push(x);
                added[x] = true;
            }
            if (i==pushed.Length && !added[p]) {
                return false;
            }
            if (stack.Count==0 || stack.Pop()!=p) {
                return false;
            }
        }
        return true;
    }
}
