// Copyright (c) 2020 Alexey Filatov
// 463 - Island Perimeter (https://leetcode.com/problems/island-perimeter)
// Date solved: 7/23/2020 5:03:07 AM +00:00
// Memory: 29.2 MB
// Runtime: 304 ms


public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var result = 0;
        if (grid==null) return result;
        for(var r = 0; r<grid.Length; r++) {
            for(var c = 0; c<grid[0].Length; c++) {
                var x = grid[r][c];
                if (x==0) continue;
                
                if (r-1<0 || grid[r-1][c]==0) result++;
                if (r+1>=grid.Length || grid[r+1][c]==0) result++;
                if (c-1<0 || grid[r][c-1]==0) result++;
                if (c+1>=grid[0].Length || grid[r][c+1]==0) result++;
            }
        }
        return result;
    }
}
