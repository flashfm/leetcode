// Copyright (c) 2024 Alexey Filatov
// 36 - Valid Sudoku (https://leetcode.com/problems/valid-sudoku)
// Date solved: 11/1/2024 7:19:33 PM +00:00
// Memory: 46.3 MB
// Runtime: 1 ms


public class Solution {
    int x;
    public bool IsValidSudoku(char[][] board) {
        for(var r=0; r<9; r++) {
            x = 0;
            for(var c=0; c<9; c++) {
                if (!Check(board[r][c])) {
                    return false;
                }
            }
        }
        for(var c=0; c<9; c++) {
            x = 0;
            for(var r=0; r<9; r++) {
                if (!Check(board[r][c])) {
                    return false;
                }
            }
        }
        for(var by = 0; by<9; by += 3) {
            for(var bx = 0; bx<9; bx +=3 ) {
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
