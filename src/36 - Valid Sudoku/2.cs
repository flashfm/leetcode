// Copyright (c) 2020 Alexey Filatov
// 36 - Valid Sudoku (https://leetcode.com/problems/valid-sudoku)
// Date solved: 10/1/2020 5:06:24 AM +00:00
// Memory: 28.1 MB
// Runtime: 108 ms


/*
[
[".",".","4", ".",".",".", "6","3","."],
[".",".",".", ".",".",".", ".",".","."],
["5",".",".", ".",".",".", ".","9","."],

[".",".",".", "5","6",".", ".",".","."],
["4",".","3", ".",".",".", ".",".","1"],
[".",".",".", "7",".",".", ".",".","."],

[".",".",".", "5",".",".", ".",".","."],
[".",".",".", ".",".",".", ".",".","."],
[".",".",".", ".",".",".", ".",".","."]]
*/
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var hashset = new HashSet<string>();
        for(var i=0;i<9;i++) {
            for(var j=0;j<9;j++) {
                var b = board[i][j];
                if (b=='.') {
                    continue;
                }
                var r = $"{b}r{i}";
                var c = $"{b}c{j}";
                var x = $"{b}x{i/3}{j/3}";
                if (hashset.Contains(r) || hashset.Contains(c) || hashset.Contains(x)) {
                    return false;
                }
                hashset.Add(r);
                hashset.Add(c);
                hashset.Add(x);
            }
        }
        return true;
    }
}
