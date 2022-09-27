// Island Perimeter
// https://leetcode.com/problems/island-perimeter
// Date solved: 07/23/2020 05:03:07 +00:00

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
