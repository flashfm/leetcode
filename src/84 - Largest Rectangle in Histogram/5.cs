// Copyright (c) 2024 Alexey Filatov
// 84 - Largest Rectangle in Histogram (https://leetcode.com/problems/largest-rectangle-in-histogram)
// Date solved: 12/5/2024 6:50:47 AM +00:00
// Memory: 53.1 MB
// Runtime: 10 ms


public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var n = heights.Length;
        var stack = new Stack<int>();
        var result = int.MinValue;
        for(var i=0; i<=n; i++) {
            var h = i==n ? -1 : heights[i];
            while(stack.Count>0 && h < heights[stack.Peek()]) {
                var higherOnLeft = heights[stack.Pop()];
                var distanceToLower = i - 1 - (stack.Count==0 ? -1 : stack.Peek());
                result = Math.Max(result, higherOnLeft * distanceToLower);
            }
            stack.Push(i);
        }
        return result;
    }
}
