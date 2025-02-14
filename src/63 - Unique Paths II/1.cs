// Copyright (c) 2024 Alexey Filatov
// 63 - Unique Paths II (https://leetcode.com/problems/unique-paths-ii)
// Date solved: 10/15/2024 6:23:31 AM +00:00
// Memory: 40.4 MB
// Runtime: 50 ms


public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var m = obstacleGrid.Length;
        if (m==0) {
            return 0;
        }
        var n = obstacleGrid[0].Length;
        int[] prevRow = null;
        var row = new int[n];
        for(var r=0; r<m; r++) {
            var obstacleRow = obstacleGrid[r];
            for(var c=0; c<n; c++) {
                if (obstacleRow[c]==1) {
                    row[c] = 0;
                }
                else if (r==0 && c==0) {
                    row[c] = 1;
                }
                else if (r==0) {
                    row[c] = row[c-1];
                }
                else if (c==0) {
                    row[c] = prevRow[c];
                }
                else {
                    row[c] = prevRow[c] + row[c-1];
                }
            }
            prevRow = row;
        }
        return prevRow[n-1];
    }
}
