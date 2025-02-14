// Copyright (c) 2024 Alexey Filatov
// 435 - Non-overlapping Intervals (https://leetcode.com/problems/non-overlapping-intervals)
// Date solved: 11/27/2024 3:15:02 AM +00:00
// Memory: 81.9 MB
// Runtime: 86 ms


public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        intervals = intervals.OrderBy(i => i[1]).ToArray();
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
