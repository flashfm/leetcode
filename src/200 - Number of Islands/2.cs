// Copyright (c) 2020 Alexey Filatov
// 200 - Number of Islands (https://leetcode.com/problems/number-of-islands)
// Date solved: 1/31/2020 7:42:26 AM +00:00
// Memory: 27.9 MB
// Runtime: 112 ms


public class Solution {
    public int NumIslands(char[][] grid) {
        var result = 0;
        for(var i=0;i<grid.Length;i++) {
            for(var j=0;j<grid[0].Length;j++) {
                if (grid[i][j]!='1') continue;
                Wave(grid, i, j);
                result++;
            }
        }
        return result;
    }
    private void Wave(char[][] grid, int i, int j)
    {
        if (i<0 || i>grid.Length-1 || j<0 || j>grid[0].Length-1 || grid[i][j]!='1') return;
        grid[i][j] = '0';
        Wave(grid, i, j-1);
        Wave(grid, i, j+1);
        Wave(grid, i-1, j);
        Wave(grid, i+1, j);
    }
}
