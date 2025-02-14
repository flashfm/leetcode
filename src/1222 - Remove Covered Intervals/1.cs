// Copyright (c) 2020 Alexey Filatov
// 1222 - Remove Covered Intervals (https://leetcode.com/problems/remove-covered-intervals)
// Date solved: 10/5/2020 2:03:26 AM +00:00
// Memory: 29.6 MB
// Runtime: 120 ms


public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        var n = intervals.Length;
        if (n<=1) return n;
        Array.Sort(intervals, (int[] a, int[] b) => {
            var cmp = a[0].CompareTo(b[0]);
            if (cmp==0) {
                cmp = -(a[1].CompareTo(b[1]));
            }
            return cmp;
        });
        var maxRight = intervals[0][1];
        var result = n;
        for(var i=1;i<n;i++) {
            var interval = intervals[i];
            if (interval[1]<=maxRight) {
                result--;                
            }
            else {
                maxRight = interval[1];
            }
        }
        return result;
    }
}
