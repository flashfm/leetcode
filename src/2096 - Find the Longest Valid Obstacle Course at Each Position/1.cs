// Copyright (c) 2024 Alexey Filatov
// 2096 - Find the Longest Valid Obstacle Course at Each Position (https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position)
// Date solved: 12/30/2024 12:26:29 AM +00:00
// Memory: 80 MB
// Runtime: 152 ms


public class Solution {
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles) {
        var n = obstacles.Length;
        var tails = new int[n];
        var result = new int[n];
        var len = 0;
        for(var j=0; j<n; j++) {
            var o = obstacles[j];
            var i = Array.BinarySearch(tails, 0, len, o+1);
            while(i-1>=0 && tails[i-1]==o+1) {
                i--;
            }
            if (i<0) {
                var idx = ~i;
                if (idx==len) {
                    len++;
                }
                i = idx;
            }
            tails[i] = o;
            result[j] = i+1;
            //Console.WriteLine(string.Join(",", tails));
        }
        return result;
    }
}
