// Copyright (c) 2020 Alexey Filatov
// 11 - Container With Most Water (https://leetcode.com/problems/container-with-most-water)
// Date solved: 10/1/2020 4:21:49 AM +00:00
// Memory: 28.5 MB
// Runtime: 108 ms


public class Solution {
    public int MaxArea(int[] height) {
        var n = height.Length;
        var s = new int[n];
        var result = -1;
        var l = 0;
        var r = n-1;
        while(l<r) {
            result = Math.Max(result, (r-l)*Math.Min(height[l], height[r]));
            if (height[l]<height[r]) {
                l++;
            }
            else {
                r--;
            }
        }
        
        return result;
    }
}
