// Copyright (c) 2024 Alexey Filatov
// 1414 - Shortest Path in a Grid with Obstacles Elimination (https://leetcode.com/problems/shortest-path-in-a-grid-with-obstacles-elimination)
// Date solved: 11/5/2024 7:51:51 PM +00:00
// Memory: 42.6 MB
// Runtime: 18 ms


public class Solution {
    (int, int)[] moves = new[] { (1, 0), (0, 1), (-1, 0), (0, -1) };

    public int ShortestPath(int[][] grid, int k) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var steps = new int[k+1, rows, cols];
        var queue = new Queue<(int,int,int)>();
        queue.Enqueue((0,0,k));
        while(queue.Count>0) {
            var (r,c,bombs) = queue.Dequeue();
            if (r==rows-1 && c==cols-1) {
                return steps[bombs,r, c];
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
        return -1;
    }
}
