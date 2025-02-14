// Copyright (c) 2024 Alexey Filatov
// 1228 - Minimum Cost Tree From Leaf Values (https://leetcode.com/problems/minimum-cost-tree-from-leaf-values)
// Date solved: 12/3/2024 6:27:23 AM +00:00
// Memory: 40.7 MB
// Runtime: 1 ms


public class Solution {
    public int MctFromLeafValues(int[] arr) {
        var stack = new Stack<int>();
        var result = 0;
        foreach(var a in arr) {
            while(stack.Count>0 && stack.Peek()<=a) {
                result += stack.Pop() * Math.Min(a, stack.Count==0 ? a : stack.Peek());
            }
            stack.Push(a);
        }
        while (stack.Count>1) {
            result += stack.Pop() * stack.Peek();
        }
        return result;
    }
}
