// Copyright (c) 2024 Alexey Filatov
// 57 - Insert Interval (https://leetcode.com/problems/insert-interval)
// Date solved: 9/25/2024 8:05:54 PM +00:00
// Memory: 50 MB
// Runtime: 120 ms


public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var n = intervals.Length;
        if (n==0) {
            return new int[][] { newInterval };
        }
        var result = new List<int[]>();
        var i = 0;
        while(i<n && intervals[i][1]<newInterval[0]) {
            result.Add(intervals[i++]);
        }
        var l = i<n ? Math.Min(newInterval[0], intervals[i][0]) : newInterval[0];
        while(i<n && intervals[i][0]<=newInterval[1]) {
            i++;
        }
        var r = i-1>=0 && i-1<n ? Math.Max(newInterval[1], intervals[i-1][1]) : newInterval[1];
        result.Add(new[] { l, r});
        while(i<n) {
            result.Add(intervals[i++]);
        }
        return result.ToArray();
    }
}
