// Copyright (c) 2020 Alexey Filatov
// 56 - Merge Intervals (https://leetcode.com/problems/merge-intervals)
// Date solved: 1/31/2020 8:53:53 AM +00:00
// Memory: 33.5 MB
// Runtime: 264 ms


public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length==0) return intervals;
        var list = new List<int[]>();
        Array.Sort(intervals, (int[] a, int[] b) => a[0].CompareTo(b[0]));
        int[] current = intervals[0];
        for(var i=1;i<intervals.Length;i++) {
            var ival = intervals[i];
            if (ival[0]<=current[1]) {
                current[1] = Math.Max(current[1], ival[1]);
            }
            else {
                list.Add(current);
                current = ival;
            }
        }
        list.Add(current);
        return list.ToArray();
    }
}
