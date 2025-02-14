// Copyright (c) 2024 Alexey Filatov
// 84 - Largest Rectangle in Histogram (https://leetcode.com/problems/largest-rectangle-in-histogram)
// Date solved: 12/5/2024 6:14:47 AM +00:00
// Memory: 54.4 MB
// Runtime: 26 ms


public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var n = heights.Length;
        var smallerLeft = new int[n];
        var stack = new Stack<int>();
        for(var i=0; i<n; i++) {
            while(stack.Count>0 && heights[i] <= heights[stack.Peek()]) {
                stack.Pop();
            }
            smallerLeft[i] = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(i);
        }
        stack.Clear();
        var smallerRight = new int[n];
        for(var i=n-1; i>=0; i--) {
            while(stack.Count>0 && heights[i] <= heights[stack.Peek()]) {
                stack.Pop();
            }
            smallerRight[i] = stack.Count == 0 ? n : stack.Peek();
            stack.Push(i);
        }
        var result = int.MinValue;
        for(var i=0; i<n; i++) {
            result = Math.Max(result, (smallerRight[i] - smallerLeft[i] - 1) * heights[i]);
        }
        return result;
    }
}
