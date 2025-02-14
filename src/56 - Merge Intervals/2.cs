// Copyright (c) 2024 Alexey Filatov
// 56 - Merge Intervals (https://leetcode.com/problems/merge-intervals)
// Date solved: 10/27/2024 4:38:22 AM +00:00
// Memory: 57 MB
// Runtime: 7 ms


public class Solution {
    public int[][] Merge(int[][] intervals) {
        var sorted = intervals.OrderBy(i => i[0]).ToArray();
        var result = new List<int[]>();
        var currentStart = sorted[0][0];
        var currentEnd = sorted[0][1];
        foreach(var i in sorted) {
            var s = i[0];
            var e = i[1];
            if (s>currentEnd) {
                result.Add(new[] {currentStart, currentEnd});
                currentStart = s;
            }
            currentEnd = Math.Max(currentEnd, e);
        }
        result.Add(new[] {currentStart, currentEnd});
        return result.ToArray();
    }
}
