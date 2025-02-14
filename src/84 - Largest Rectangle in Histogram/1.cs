// Copyright (c) 2020 Alexey Filatov
// 84 - Largest Rectangle in Histogram (https://leetcode.com/problems/largest-rectangle-in-histogram)
// Date solved: 4/18/2020 7:54:55 AM +00:00
// Memory: 26.3 MB
// Runtime: 2444 ms


public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var n = heights.Length;
        var maxArea = 0;
        for(var i = 0; i < n; i++) {
            var h = heights[i];
            var area = h;
            var j = i-1;
            while(j>=0 && heights[j]>=h) {
                area += h;
                j--;
            }
            j = i+1;
            while(j<n && heights[j]>=h) {
                area += h;
                j++;
            }
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}
