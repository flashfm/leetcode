// Copyright (c) 2024 Alexey Filatov
// 2096 - Find the Longest Valid Obstacle Course at Each Position (https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position)
// Date solved: 12/30/2024 12:33:42 AM +00:00
// Memory: 79.7 MB
// Runtime: 36 ms


public class Solution {
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles) {
        var n = obstacles.Length;
        var tails = new int[n];
        var result = new int[n];
        var len = 0;
        for(var j=0; j<n; j++) {
            var o = obstacles[j];
            var i = FindFirstStrictlyGreaterThan(o);
            if (i==-1) {
                i = len;
                len++;
            }
            tails[i] = o;
            result[j] = i+1;
        }
        return result;

        int FindFirstStrictlyGreaterThan(int e)
        {
            var l = 0;
            var r = len-1;
            var result = -1;
            while(l<=r) {
                var m = l + (r-l)/2;
                if (tails[m]<=e) {
                    l = m+1;
                }
                else {
                    result = m;
                    r = m-1;
                }
            }
            return result;
        }
    }
}
