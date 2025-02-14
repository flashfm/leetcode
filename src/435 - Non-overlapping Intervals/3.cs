// Copyright (c) 2024 Alexey Filatov
// 435 - Non-overlapping Intervals (https://leetcode.com/problems/non-overlapping-intervals)
// Date solved: 11/27/2024 3:16:25 AM +00:00
// Memory: 82.2 MB
// Runtime: 64 ms


public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (i1, i2) => i1[1].CompareTo(i2[1]));
        var end = int.MinValue;
        var result = 0;
        foreach(var i in intervals) {
            if (i[0]>=end) {
                end = i[1];
            }
            else {
                result++;
            }
        }
        return result;
    }
}
