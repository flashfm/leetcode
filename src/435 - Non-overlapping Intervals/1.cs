// Copyright (c) 2024 Alexey Filatov
// 435 - Non-overlapping Intervals (https://leetcode.com/problems/non-overlapping-intervals)
// Date solved: 11/27/2024 3:13:58 AM +00:00
// Memory: 87.4 MB
// Runtime: 112 ms


public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        var end = int.MinValue;
        var result = 0;
        foreach(var i in intervals.OrderBy(i => i[1])) {
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
