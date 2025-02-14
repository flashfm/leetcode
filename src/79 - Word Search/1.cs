// Copyright (c) 2020 Alexey Filatov
// 79 - Word Search (https://leetcode.com/problems/word-search)
// Date solved: 1/31/2020 8:00:04 AM +00:00
// Memory: 28.8 MB
// Runtime: 128 ms


public class Solution {
    public bool Exist(char[][] board, string word) {
        if (word.Length==0) return false;
        for(var i=0;i<board.Length;i++)
            for(var j=0;j<board[0].Length;j++)
                if (Backtrack(board, word, i, j, 0)) return true;
        return false;
    }
    private bool Backtrack(char[][] board, string word, int i, int j, int pos)
    {
        if (i<0 || i>=board.Length || j<0 || j>=board[0].Length || board[i][j]!=word[pos]) return false;
        var old = board[i][j];
        board[i][j] = (char)0;
        var result =
            pos==word.Length-1 ||
            Backtrack(board, word, i, j-1, pos+1) ||
            Backtrack(board, word, i, j+1, pos+1) ||
            Backtrack(board, word, i-1, j, pos+1) ||
            Backtrack(board, word, i+1, j, pos+1);        
        board[i][j] = old;
        return result;
    }
}
