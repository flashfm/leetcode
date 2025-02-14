// Copyright (c) 2024 Alexey Filatov
// 1349 - Check If It Is a Straight Line (https://leetcode.com/problems/check-if-it-is-a-straight-line)
// Date solved: 12/18/2024 10:15:34 PM +00:00
// Memory: 44.9 MB
// Runtime: 0 ms


public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        var n = coordinates.Length;
        if (n<=2) {
            return true;
        }
        var x = coordinates[0][0];
        var y = coordinates[0][1];
        var dx = coordinates[1][0] - x;
        var dy = coordinates[1][1] - y;
        for(var i=2; i<n; i++) {
            var dx1 = coordinates[i][0] - x;
            var dy1 = coordinates[i][1] - y;
            if (dy*dx1!=dy1*dx) {
                return false;
            }
        }
        return true;
    }
}
