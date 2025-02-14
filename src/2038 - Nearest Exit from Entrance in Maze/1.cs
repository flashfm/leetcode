// Copyright (c) 2024 Alexey Filatov
// 2038 - Nearest Exit from Entrance in Maze (https://leetcode.com/problems/nearest-exit-from-entrance-in-maze)
// Date solved: 11/16/2024 1:25:18 AM +00:00
// Memory: 75.7 MB
// Runtime: 5 ms


public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var n = maze.Length;
        var m = maze[0].Length;
        var queue = new Queue<(int,int,int)>();
        queue.Enqueue((entrance[0], entrance[1],0));
        maze[entrance[0]][entrance[1]] = '$';
        var moves = new[] {(1,0), (0,1), (-1,0), (0,-1)};
        var result = 0;
        while(queue.Count>0) {
            var (r,c,len) = queue.Dequeue();
            foreach(var (dr, dc) in moves) {
                var newR = r+dr;
                var newC = c+dc;
                if (newR==-1 || newR==n || newC==-1 || newC==m) {
                    if (r!=entrance[0] || c!=entrance[1]) {
                        return len;
                    }
                    else {
                        continue;
                    }
                }
                if (maze[newR][newC]=='.') {
                    maze[newR][newC] = '$';
                    queue.Enqueue((newR, newC, len+1));
                }
            }
        }
        return -1;
    }
}
