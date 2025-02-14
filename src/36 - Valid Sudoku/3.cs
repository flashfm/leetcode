// Copyright (c) 2024 Alexey Filatov
// 36 - Valid Sudoku (https://leetcode.com/problems/valid-sudoku)
// Date solved: 11/1/2024 7:12:58 PM +00:00
// Memory: 46.8 MB
// Runtime: 1 ms


public class Solution {
    int x;
    public bool IsValidSudoku(char[][] board) {
        if (board.Length==0 || board[0].Length==0) {
            return true;
        }
        foreach(var row in board) {
            x = 0;
            foreach(var c in row) {
                if (!Check(c)) {
                    return false;
                }
            }
        }
        for(var c=0; c<board[0].Length; c++) {
            x = 0;
            for(var r=0; r<board.Length; r++) {
                if (!Check(board[r][c])) {
                    return false;
                }
            }
        }
        for(var by = 0; by<board.Length; by += 3) {
            for(var bx = 0; bx<board[0].Length; bx +=3 ) {
                x = 0;
                for(var y = by; y<by+3; y++) {
                    for(var x = bx; x<bx+3; x++) {
                        if (!Check(board[y][x])) {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }

    private bool Check(char c)
    {
        if (c!='.') {
            var n = c-'0';
            var mask = 1<<n;
            if ((x & mask) != 0) {
                return false;
            }
            x |= mask;
        }
        return true;
    }
}
