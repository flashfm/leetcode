// Copyright (c) 2020 Alexey Filatov
// 200 - Number of Islands (https://leetcode.com/problems/number-of-islands)
// Date solved: 1/31/2020 7:34:29 AM +00:00
// Memory: 28.3 MB
// Runtime: 108 ms


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
    private void Wave(char[][] grid, int i0, int j0)
    {
        var queue = new Queue<int[]>();
        queue.Enqueue(new[] {i0,j0});
        grid[i0][j0] = '0';
        while(queue.Count>0) {
            var pos = queue.Dequeue();
            int i = pos[0], j = pos[1];
            grid[i][j] = '0';
            for(var di=-1; di<=1; di++)
                for(var dj=-1; dj<=1; dj++) {
                    int ni = i+di, nj = j+dj;
                    if (dj*di==0 && ni>=0 && ni<grid.Length && nj>=0 && nj<grid[0].Length && grid[ni][nj]=='1') {
                        grid[ni][nj] = '0';
                        queue.Enqueue(new[] {ni,nj});
                    }
                
            }
        }
    }
}
