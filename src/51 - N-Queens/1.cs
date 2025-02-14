// Copyright (c) 2024 Alexey Filatov
// 51 - N-Queens (https://leetcode.com/problems/n-queens)
// Date solved: 12/7/2024 5:17:51 AM +00:00
// Memory: 53.1 MB
// Runtime: 4 ms


public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var queenRow = new string[n];
        var dots = new char[n];
        Array.Fill(dots, '.');
        for(var i=0; i<n; i++) {
            dots[i] = 'Q';
            queenRow[i] = new string(dots);
            dots[i] = '.';
        }
        var usedRows = new bool[n];
        var usedCols = new bool[n];
        var usedSum = new bool[n*2];
        var usedDiff = new bool[n*2]; // -n till n (+n always)
        var results = new List<IList<string>>();
        var board = new string[n];
        Backtrack(0, n);
        return results;

        void Backtrack(int r, int queensToGo)
        {
            if (usedRows[r]) {
                return;
            }
            for(var c=0; c<n; c++) {
                if (usedCols[c] || usedSum[r+c] || usedDiff[n+r-c]) {
                    continue;
                }
                var oldRow = board[r];
                board[r] = queenRow[c];
                usedRows[r] = usedCols[c] = usedSum[r+c] = usedDiff[n+r-c] = true;
                if (queensToGo==1) {
                    results.Add(board.ToArray());
                }
                else {
                    Backtrack(r+1, queensToGo-1);
                }
                usedRows[r] = usedCols[c] = usedSum[r+c] = usedDiff[n+r-c] = false;
                board[r] = oldRow;
            }
        }
    }
}
