// Copyright (c) 2024 Alexey Filatov
// 1414 - Shortest Path in a Grid with Obstacles Elimination (https://leetcode.com/problems/shortest-path-in-a-grid-with-obstacles-elimination)
// Date solved: 11/5/2024 7:49:01 PM +00:00
// Memory: 45.1 MB
// Runtime: 98 ms


public class Solution {
    int[][] grid;
    int[,,] steps;
    int rows;
    int cols;
    (int, int)[] moves = new[] { (1, 0), (0, 1), (-1, 0), (0, -1) };
    int result = int.MaxValue;

    public int ShortestPath(int[][] grid, int k) {
        this.grid = grid;    
        rows = grid.Length;
        cols = grid[0].Length;
        steps = new int[k+1, rows, cols];
        var queue = new Queue<(int,int,int)>();
        queue.Enqueue((0,0,k));
        while(queue.Count>0) {
            var (r,c,bombs) = queue.Dequeue();
            if (r==rows-1 && c==cols-1) {
                result = Math.Min(result, steps[bombs,r, c]);
            }
            var newSteps = steps[bombs,r,c]+1;
            foreach(var (dr, dc) in moves) {
                var newR = r+dr;
                var newC = c+dc;
                if (newR<0 || newR==rows || newC<0 || newC==cols) {
                    continue;
                }
                var newBombs = bombs - grid[newR][newC];
                if (newBombs<0) {
                    continue;
                }
                if (steps[newBombs,newR,newC]==0 || steps[newBombs,newR,newC]>newSteps) {
                    steps[newBombs,newR, newC] = newSteps;
                    queue.Enqueue((newR,newC,newBombs));
                }
            }
        }
        return result==int.MaxValue ? -1 : result;
    }
}
