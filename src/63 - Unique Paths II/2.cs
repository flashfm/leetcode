// Copyright (c) 2024 Alexey Filatov
// 63 - Unique Paths II (https://leetcode.com/problems/unique-paths-ii)
// Date solved: 10/15/2024 6:27:52 AM +00:00
// Memory: 40.5 MB
// Runtime: 64 ms


public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var m = obstacleGrid.Length;
        if (m==0) {
            return 0;
        }
        var n = obstacleGrid[0].Length;
        var row = new int[n];
        row[0] = 1;
        for(var r=0; r<m; r++) {
            var obstacleRow = obstacleGrid[r];
            for(var c=0; c<n; c++) {
                if (obstacleRow[c]==1) {
                    row[c] = 0;
                }
                else if (c>0) {
                    row[c] += row[c-1];
                }
            }
        }
        return row[n-1];
    }
}
