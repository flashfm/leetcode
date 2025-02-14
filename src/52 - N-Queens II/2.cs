// Copyright (c) 2024 Alexey Filatov
// 52 - N-Queens II (https://leetcode.com/problems/n-queens-ii)
// Date solved: 10/10/2024 3:27:24 AM +00:00
// Memory: 26.7 MB
// Runtime: 642 ms


using System.Runtime.CompilerServices;
public class Solution {    
    private int n;
    private int[] board; // 1+ = busy
    private int current;
    private int result;

    public int TotalNQueens(int n) {
        this.n = n;
        board = new int[n*n];
        Dfs(0);
        return result;
    }
    private void Dfs(int start)
    {
        for(var i = start; i<n*n; i++) {
            if (board[i]!=0) {
                continue;
            }
            if (current==n-1) {
                result++;
            }
            else {
                current++;
                Mark(i, 1);
                var nextRow = i/n+1;
                Dfs(nextRow*n);
                Mark(i, -1);
                current--;
            }
        }
    }
    private void Mark(int i, int d)
    {
        var r = i / n;
        var c = i % n;
        for(var j = 0; j<n; j++) {
            Increment(j, c, d);
            Increment(r, j, d);
            Increment(r-j, c-j, d);
            Increment(r-j, c+j, d);
            Increment(r+j, c-j, d);
            Increment(r+j, c+j, d);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Increment(int r, int c, int d)
    {
        if (r>=0 && r<n && c>=0 && c<n) {
            board[r*n+c] += d;
        }
    }
}
