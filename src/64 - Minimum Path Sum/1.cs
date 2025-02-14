// Copyright (c) 2024 Alexey Filatov
// 64 - Minimum Path Sum (https://leetcode.com/problems/minimum-path-sum)
// Date solved: 10/15/2024 6:05:47 AM +00:00
// Memory: 45.2 MB
// Runtime: 99 ms


public class Solution {
    public int MinPathSum(int[][] grid) {
        if (grid.Length==0) {
            return 0;
        }
        for(var i = 0; i<grid.Length; i++) {
            for(var j = 0; j<grid[0].Length; j++) {
                grid[i][j] += i==0 ? (j==0 ? 0 : grid[i][j-1]) :
                (j==0 ? grid[i-1][j] : Math.Min(grid[i-1][j], grid[i][j-1]));
            }
        }
        return grid.Last().Last();
    }
}
