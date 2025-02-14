// Copyright (c) 2020 Alexey Filatov
// 130 - Surrounded Regions (https://leetcode.com/problems/surrounded-regions)
// Date solved: 10/6/2020 4:45:37 PM +00:00
// Memory: 35.5 MB
// Runtime: 304 ms


public class Solution {
    private char[][] board;
    private bool[,] visited;
    private int rows;
    private int cols;
    public void Solve(char[][] board) {
        this.board = board;
        rows = board.Length;
        if (rows==0) {
            return;
        }
        cols = board[0].Length;
        visited = new bool[rows,cols];
        for(var i=0; i<rows; i++) {
            for(var j = 0; j<cols; j++) {
                if (!visited[i,j] && board[i][j]=='O') {
                    Bfs(i, j);
                }
            }
        }
    }
    private void Bfs(int r, int c)
    {
        var queue = new Queue<(int r, int c)>();
        var toInvert = new List<(int r, int c)>();
        queue.Enqueue((r,c));
        visited[r,c] = true;
        var invert = r!=0 && r!=rows-1 && c!=0 && c!=cols-1;
        while(queue.Count>0) {
            var p = queue.Dequeue();
            toInvert.Add(p);
            foreach(var d in new (int r, int c)[] {(-1,0), (0,1), (1,0), (0,-1)}) {
                var newR = p.r + d.r;
                var newC = p.c + d.c;
                if (newR>=0 && newR<rows && newC>=0 && newC<cols && board[newR][newC]=='O' && !visited[newR, newC]) {
                    queue.Enqueue((newR, newC));
                    visited[newR, newC] = true;
                    
                    if (newR==0 || newR==rows-1 || newC==0 || newC==cols-1) {
                        invert = false;
                    }
                }
            }
        }
        if (invert) {
            foreach(var p in toInvert) {
                board[p.r][p.c] = 'X';
            }
        }
    }
}
