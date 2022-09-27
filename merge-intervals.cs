// Merge Intervals
// https://leetcode.com/problems/merge-intervals
// Date solved: 01/31/2020 08:53:53 +00:00

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
