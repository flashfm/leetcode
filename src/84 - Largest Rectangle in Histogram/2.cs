// Copyright (c) 2020 Alexey Filatov
// 84 - Largest Rectangle in Histogram (https://leetcode.com/problems/largest-rectangle-in-histogram)
// Date solved: 4/18/2020 10:57:52 PM +00:00
// Memory: 26.5 MB
// Runtime: 168 ms


/*

*    * *
*  * ***
** *****
** *****
01234567

*/

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var n = heights.Length;
        if (n==0) return 0;
        
        var indexOfLowerLeft = new int[n];
        indexOfLowerLeft[0] = -1;
        for(var i = 1; i<n; i++) {
            var p = i-1;
            while(p>=0 && heights[p]>=heights[i]) {
                p = indexOfLowerLeft[p];
            }
            indexOfLowerLeft[i] = p;
        }
        var indexOfLowerRight = new int[n];
        indexOfLowerRight[n-1] = n;
        for(var i=n-2; i>=0; i--) {            
            var p = i+1;
            while(p<n && heights[p]>=heights[i]) {
                p = indexOfLowerRight[p];
            }
            indexOfLowerRight[i] = p;
        }

        var maxArea = 0;
        for(var i = 0; i < n; i++) {
            var h = heights[i];
            var area = (indexOfLowerRight[i] - indexOfLowerLeft[i] - 1)*h;
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}
