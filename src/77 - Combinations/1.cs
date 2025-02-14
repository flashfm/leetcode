// Copyright (c) 2024 Alexey Filatov
// 77 - Combinations (https://leetcode.com/problems/combinations)
// Date solved: 10/8/2024 11:26:32 PM +00:00
// Memory: 153 MB
// Runtime: 437 ms


public class Solution {
    private List<IList<int>> result = new();
    private int len;
    private int end;

    public IList<IList<int>> Combine(int n, int k) {
        var stack = new Stack<int>();
        stack.Push(1);
        var prev = 1;
        while(prev!=-1) {
            if (stack.Count==k) {
                result.Add(stack.Reverse().ToArray());
            }
            if (stack.Count<k && prev<n) {
                prev = prev+1;
                stack.Push(prev);
            }
            else {
                prev = stack.Count>0 ? stack.Pop() : -1;
            }
        }
        return result;
    }
}
