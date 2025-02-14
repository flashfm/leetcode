// Copyright (c) 2020 Alexey Filatov
// 84 - Largest Rectangle in Histogram (https://leetcode.com/problems/largest-rectangle-in-histogram)
// Date solved: 4/19/2020 5:16:49 AM +00:00
// Memory: 26.9 MB
// Runtime: 172 ms


/*

*    * *
*  * ***
** *****
** *****
01234567

*/

public class Solution {
    private int maxArea = 0;
    private Stack<int> stack = new Stack<int>(); // indexes
    private int[] heights;
    
    public int LargestRectangleArea(int[] heights) {
        var n = heights.Length;
        if (n==0) return 0;

        this.heights = heights;
        var i = 0;
        while(i<n) {
            if (stack.Count==0 || heights[i]>=heights[stack.Peek()]) {
                stack.Push(i);
                i++;
            }
            else {
                Pop(i);
            }
        }
        while(stack.Count>0) {
            Pop(i);
        }
        
        return maxArea;
    }
    
    private void Pop(int i)
    {
        var index = stack.Pop();
        var h = heights[index];
        var w = stack.Count==0 ? i : i - stack.Peek() - 1;
        maxArea = Math.Max(maxArea, w*h);
    }
}
