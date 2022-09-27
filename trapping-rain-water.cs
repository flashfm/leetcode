// Trapping Rain Water
// https://leetcode.com/problems/trapping-rain-water
// Date solved: 03/27/2020 04:18:02 +00:00

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
