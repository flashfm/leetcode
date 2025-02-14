// Copyright (c) 2020 Alexey Filatov
// 1222 - Remove Covered Intervals (https://leetcode.com/problems/remove-covered-intervals)
// Date solved: 10/5/2020 2:09:54 AM +00:00
// Memory: 29.7 MB
// Runtime: 112 ms


public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        var n = intervals.Length;
        if (n<=1) return n;
        Array.Sort(intervals, (int[] a, int[] b) => {
            var cmp = a[0].CompareTo(b[0]);
            return cmp==0 ? b[1].CompareTo(a[1]) : cmp;
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
