// Copyright (c) 2024 Alexey Filatov
// 200 - Number of Islands (https://leetcode.com/problems/number-of-islands)
// Date solved: 10/27/2024 4:50:30 AM +00:00
// Memory: 51.9 MB
// Runtime: 119 ms


public class Solution {
    private static (int, int)[] moves = new[] { (1, 0), (-1, 0), (0, 1), (0, -1) }; 
    public int NumIslands(char[][] grid) {
        var result = 0;
        var queue = new Queue<(int,int)>();
        for(var initR = 0; initR<grid.Length; initR++) {
            for(var initC = 0; initC<grid[0].Length; initC++) {
                if (grid[initR][initC]=='0') {
                    continue;
                }
                grid[initR][initC] = '0';
                queue.Enqueue((initR, initC));
                while(queue.Count>0) {
                    var (r,c) = queue.Dequeue();
                    foreach(var (dr, dc) in moves) {
                        var r1 = r+dr;
                        var c1 = c+dc;
                        if (r1>-1 && r1<grid.Length && c1>-1 && c1<grid[0].Length && grid[r1][c1]=='1') {
                            grid[r1][c1] = '0';
                            queue.Enqueue((r1,c1));
                        }
                    }
                }
                result++;
            }
        }
        return result;
    }
}
