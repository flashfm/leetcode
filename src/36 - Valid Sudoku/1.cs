// Copyright (c) 2020 Alexey Filatov
// 36 - Valid Sudoku (https://leetcode.com/problems/valid-sudoku)
// Date solved: 10/1/2020 4:44:23 AM +00:00
// Memory: 28.6 MB
// Runtime: 112 ms


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
        var hashset = new HashSet<char>();
        var hashset2 = new HashSet<char>();
        for(var i=0;i<9;i++) {
            hashset.Clear();
            hashset2.Clear();
            for(var j=0;j<9;j++) {
                var c = board[i][j];
                if (c!='.') {
                    if (hashset.Contains(c)) {
                        return false;
                    }
                    hashset.Add(c);
                }
                var d = board[j][i];
                if (d!='.') {
                    if (hashset2.Contains(d)) {
                        return false;
                    }
                    hashset2.Add(d);
                }
            }
            if (i==3) {
                Console.WriteLine(string.Join(",", hashset2));
            }
        }
        for(var l=0;l<9;l+=3) {
            for(var r=0;r<9;r+=3) {
                if (!IsValidBlock(board, l, r)) {
                    return false;
                }
            }
        }
        return true;
    }
    private bool IsValidBlock(char[][] board, int l, int t)
    {
        var hashset = new HashSet<char>();
        for(var i = l; i<l+3; i++) {
            for(var j = t; j<t+3; j++) {
                var c = board[i][j];
                if (c=='.') {
                    continue;
                }
                if (hashset.Contains(c)) {
                    return false;
                }
                hashset.Add(c);                
            }            
        }
        return true;
    }
}
