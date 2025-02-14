// Copyright (c) 2024 Alexey Filatov
// 200 - Number of Islands (https://leetcode.com/problems/number-of-islands)
// Date solved: 10/27/2024 4:46:13 AM +00:00
// Memory: 52.7 MB
// Runtime: 137 ms


public class Solution {

    char[][] grid;
    bool[,] visited;
    public int NumIslands(char[][] grid) {
        this.grid = grid;
        visited = new bool[grid.Length, grid[0].Length];
        var result = 0;
        for(var r = 0; r<grid.Length; r++) {
            for(var c = 0; c<grid[0].Length; c++) {
                if (grid[r][c]=='1' && !visited[r,c]) {
                    Visit(r,c);
                    result++;
                }
            }
        }
        return result;
    }

    private static (int, int)[] moves = new[] { (1, 0), (-1, 0), (0, 1), (0, -1) };

    private void Visit(int initR, int initC)
    {
        var queue = new Queue<(int,int)>();
        visited[initR, initC] = true;
        queue.Enqueue((initR, initC));
        while(queue.Count>0) {
            var (r,c) = queue.Dequeue();
            foreach(var (dr, dc) in moves) {
                var r1 = r+dr;
                var c1 = c+dc;
                if (r1>-1 && r1<grid.Length && c1>-1 && c1<grid[0].Length && grid[r1][c1]=='1' && !visited[r1, c1]) {
                    visited[r1,c1] = true;
                    queue.Enqueue((r1,c1));
                }
            }
        }
    }    
}
