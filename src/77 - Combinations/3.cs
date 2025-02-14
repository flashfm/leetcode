// Copyright (c) 2024 Alexey Filatov
// 77 - Combinations (https://leetcode.com/problems/combinations)
// Date solved: 10/9/2024 12:04:58 AM +00:00
// Memory: 140.3 MB
// Runtime: 372 ms


public class Solution {
    private List<IList<int>> result = new();
    private int len;
    private int end;

    public IList<IList<int>> Combine(int n, int k) {
        var stack = new List<int>(k);
        stack.Add(1);
        var prev = 1;
        while(true) {
            if (stack.Count==k) {
                result.Add(stack.ToArray());
            }
            if (stack.Count<k && prev<n) {
                prev = prev+1;
                stack.Add(prev);
            }
            else {
                if (stack.Count>0) {
                    prev = stack[stack.Count-1];
                    stack.RemoveAt(stack.Count-1);
                }
                else {
                    break;
                }
            }
        }
        return result;
    }
}
