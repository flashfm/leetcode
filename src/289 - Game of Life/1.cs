// Copyright (c) 2021 Alexey Filatov
// 289 - Game of Life (https://leetcode.com/problems/game-of-life)
// Date solved: 1/29/2021 5:24:18 AM +00:00
// Memory: 30.3 MB
// Runtime: 308 ms


public class Solution {
    private int[][] board;
    public void GameOfLife(int[][] board) {
        this.board = board;
        if (board == null || board.Length==0) {
            return;
        }
        var m = board[0].Length;
        if (m==0) {
            return;
        }
        for(var r = 0; r<board.Length; r++) {
            for(var c = 0; c<m; c++) {
                var live = GetNeighbours(r, c);
                //Console.WriteLine(live);
                Set(r, c, board[r][c] & 1);
                if (IsLive(r, c)) {
                    if (live<2 || live>3) {
                        Set(r, c, 0);
                    }
                    else {
                        Set(r, c, 1);
                    }
                }
                else {
                    if (live==3) {
                        Set(r, c, 1);
                    }
                }
            }
        }
        for(var r = 0; r<board.Length; r++) {
            for(var c = 0; c<m; c++) {
                board[r][c] = board[r][c]>1 ? 1 : 0;
            }
        }        
    }
    private void Set(int r, int c, int v)
    {
        if (v==1) {
            board[r][c] += 2;
        }
        else if (board[r][c]>1) {
            board[r][c] -= 2;
        }
    }    
    private bool IsLive(int r, int c)
    {
        return (board[r][c] & 1) == 1;    
    }
    private int GetNeighbours(int r, int c)
    {
        var result = 0;
        for(var dr=-1; dr<2; dr++) {
            var nr = r+dr;
            if (nr<0 || nr>=board.Length) {
                continue;
            }
            for(var dc=-1; dc<2; dc++) {
                var nc = c+dc;
                if (nc<0 || nc>=board[0].Length || (nc==c && nr==r)) {
                    continue;
                }
                if (IsLive(nr, nc)) {
                    result++;
                }
            }
        }
        return result;
    }
}
