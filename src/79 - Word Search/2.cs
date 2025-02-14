// Copyright (c) 2024 Alexey Filatov
// 79 - Word Search (https://leetcode.com/problems/word-search)
// Date solved: 11/5/2024 5:06:52 AM +00:00
// Memory: 42.3 MB
// Runtime: 189 ms


public class Solution {
    public bool Exist(char[][] board, string word) {
        for(var r = 0; r<board.Length; r++) {
            for(var c = 0; c<board[0].Length; c++) {
                if (Dfs(board, r, c, word, 0)) {
                    return true;
                }
            }
        }
        return false;
    }
    private bool Dfs(char[][] board, int r, int c, string word, int pos)
    {
        if (r<0 || r>=board.Length || c<0 || c>=board[0].Length) {
            return false;
        }
        if (board[r][c]!=word[pos]) {
            return false;
        }
        if (pos==word.Length-1) {
            return true;
        }
        board[r][c] = '#';
        var result =
            Dfs(board, r+1, c, word, pos+1) ||
            Dfs(board, r-1, c, word, pos+1) ||
            Dfs(board, r, c+1, word, pos+1) ||
            Dfs(board, r, c-1, word, pos+1);
        board[r][c] = word[pos];
        return result;
    }
}
