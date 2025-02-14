// Copyright (c) 2024 Alexey Filatov
// 1380 - Number of Closed Islands (https://leetcode.com/problems/number-of-closed-islands)
// Date solved: 10/23/2024 3:32:17 AM +00:00
// Memory: 43.7 MB
// Runtime: 8 ms


public class Solution {
    int[][] grid;
    bool[,] visited;
    public int ClosedIsland(int[][] grid) {
        this.grid = grid;
        visited = new bool[grid.Length, grid[0].Length];
        var result = 0;
        for(var r = 0; r<grid.Length; r++) {
            for(var c = 0; c<grid[0].Length; c++) {
                if (grid[r][c]==0 && !visited[r,c]) {
                    result += Visit(r,c);
                }
            }
        }
        return result;
    }

    private static (int, int)[] moves = new[] { (1, 0), (-1, 0), (0, 1), (0, -1) };

    private int Visit(int initR, int initC)
    {
        var queue = new Queue<(int,int)>();
        visited[initR, initC] = true;
        queue.Enqueue((initR, initC));
        var touching = false;
        while(queue.Count>0) {
            var (r,c) = queue.Dequeue();
            if (r==0 || r==grid.Length-1 || c==0 || c==grid[0].Length-1) {
                touching = true;
            }
            foreach(var (dr, dc) in moves) {
                var r1 = r+dr;
                var c1 = c+dc;
                if (r1>-1 && r1<grid.Length && c1>-1 && c1<grid[0].Length && grid[r1][c1]==0 && !visited[r1, c1]) {
                    visited[r1,c1] = true;
                    queue.Enqueue((r1,c1));
                }
            }
        }
        return touching ? 0 : 1;
    }
}
