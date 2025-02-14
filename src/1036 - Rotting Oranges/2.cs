// Copyright (c) 2024 Alexey Filatov
// 1036 - Rotting Oranges (https://leetcode.com/problems/rotting-oranges)
// Date solved: 11/16/2024 1:53:03 AM +00:00
// Memory: 41.5 MB
// Runtime: 2 ms


public class Solution {
    public int OrangesRotting(int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;   
        var queue = new Queue<(int,int)>();
        for(var r=0; r<m; r++) {
            for(var c=0; c<n; c++) {
                if (grid[r][c]==2) {
                    grid[r][c] = 0; 
                    queue.Enqueue((r,c));
                }
            }
        }
        var moves = new[] {(1,0),(0,1),(-1,0),(0,-1)};
        while(queue.Count>0) {
            var (r,c) = queue.Dequeue();
            foreach(var (dr,dc) in moves) {
                var newR = r+dr;
                var newC = c+dc;
                if (newR==-1 || newR==m || newC==-1 || newC==n || grid[newR][newC]!=1) {
                    continue;
                }
                grid[newR][newC] = grid[r][c]-1;
                queue.Enqueue((newR,newC));
            }
        }
        var max = 0;
        foreach(var row in grid) {
            foreach(var cell in row) {
                if (cell==1) {
                    return -1;
                }
                if (cell<0) {
                    max = Math.Max(max, -cell);
                }
            }
        }
        return max;
    }
}
