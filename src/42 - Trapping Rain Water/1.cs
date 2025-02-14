// Copyright (c) 2020 Alexey Filatov
// 42 - Trapping Rain Water (https://leetcode.com/problems/trapping-rain-water)
// Date solved: 3/27/2020 4:18:02 AM +00:00
// Memory: 25.2 MB
// Runtime: 96 ms


    public class Solution
    {
        public int Trap(int[] height)
        {
            var n = height.Length;
            if (n==0) return 0;
            var maxl = new int[n];
            var maxr = new int[n];
            maxl[0] = height[0];
            for(var i = 1; i<n; i++) {
                maxl[i] = Math.Max(maxl[i-1], height[i]);
            }
            maxr[n-1] = height[n-1];
            for(var i = n-2; i>=0; i--) {
                maxr[i] = Math.Max(maxr[i+1], height[i]);
            }
            var result = 0;
            for(var i=0; i<n; i++) {
                result += Math.Min(maxl[i], maxr[i]) - height[i];
            }
            return result;
        }
    }
