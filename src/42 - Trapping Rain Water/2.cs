// Copyright (c) 2024 Alexey Filatov
// 42 - Trapping Rain Water (https://leetcode.com/problems/trapping-rain-water)
// Date solved: 10/29/2024 6:43:51 PM +00:00
// Memory: 46.9 MB
// Runtime: 1 ms


public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        var maxR = new int[n];
        for(var i=n-2; i>=0; i--) {
            maxR[i] = Math.Max(maxR[i+1], height[i+1]);
        }
        var maxL = new int[n];
        for(var i = 1; i<n; i++) {
            maxL[i] = Math.Max(maxL[i-1], height[i-1]);
        }
        var result = 0;
        for(var i = 0; i<n; i++) {
            var min = Math.Min(maxR[i], maxL[i]);
            result += Math.Max(0, min - height[i]);
        }
        return result;
    }
}
