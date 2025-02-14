// Copyright (c) 2024 Alexey Filatov
// 452 - Minimum Number of Arrows to Burst Balloons (https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons)
// Date solved: 9/25/2024 9:51:27 PM +00:00
// Memory: 81.1 MB
// Runtime: 583 ms


public class Solution {
    public int FindMinArrowShots(int[][] points) {
        var n = points.Length;
        if (n==0) {
            return 0;
        }
        Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));
        var result = 0;
        var i = 0;
        while(i<n) {
            var x = int.MaxValue;
            while(i<n && points[i][0]<=x) {
                x = Math.Min(x, points[i][1]);
                i++;
            }
            result++;
        }
        return result;
    }
}
