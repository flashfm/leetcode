// Copyright (c) 2024 Alexey Filatov
// 77 - Combinations (https://leetcode.com/problems/combinations)
// Date solved: 10/9/2024 12:02:57 AM +00:00
// Memory: 153.2 MB
// Runtime: 423 ms


public class Solution {
    private List<IList<int>> result = new();
    private int len;
    private int end;

    public IList<IList<int>> Combine(int n, int k) {
        var stack = new Stack<int>(k);
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
