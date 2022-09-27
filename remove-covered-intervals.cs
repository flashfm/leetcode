// Remove Covered Intervals
// https://leetcode.com/problems/remove-covered-intervals
// Date solved: 10/05/2020 02:11:36 +00:00

public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        var n = intervals.Length;
        if (n<=1) return n;
        Array.Sort(intervals, (int[] a, int[] b) => a[0]==b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));
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
