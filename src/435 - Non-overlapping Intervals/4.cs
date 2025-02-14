// Copyright (c) 2024 Alexey Filatov
// 435 - Non-overlapping Intervals (https://leetcode.com/problems/non-overlapping-intervals)
// Date solved: 11/27/2024 3:17:19 AM +00:00
// Memory: 82.9 MB
// Runtime: 54 ms


public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (i1, i2) => i1[1].CompareTo(i2[1]));
        var end = int.MinValue;
        var nonIntersecting = 0;
        foreach(var i in intervals) {
            if (i[0]>=end) {
                end = i[1];
                nonIntersecting++;
            }
        }
        return intervals.Length - nonIntersecting;
    }
}
