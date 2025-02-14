// Copyright (c) 2024 Alexey Filatov
// 52 - N-Queens II (https://leetcode.com/problems/n-queens-ii)
// Date solved: 10/10/2024 3:49:58 AM +00:00
// Memory: 26.5 MB
// Runtime: 137 ms


using System.Runtime.CompilerServices;
public class Solution {    
    private int n;
    private int current;
    private int result;
    private int[] busyRows; // 1+ = busy
    private int[] busyCols; // 1+ = busy
    private int[] busyXDiag; // 1+ = busy
    private int[] busyYDiag; // 1+ = busy

    public int TotalNQueens(int n) {
        this.n = n;
        busyRows = new int[n];
        busyCols = new int[n];
        busyXDiag = new int[n*2];
        busyYDiag = new int[n*2];
        Dfs(0);
        return result;
    }
    private void Dfs(int startRow)
    {
        for(var r = startRow; r<n; r++) {
            if (busyRows[r]!=0) {
                continue;
            }
            for(var c = 0; c<n; c++) {
                if (busyCols[c]!=0 || busyXDiag[c-r+n]!=0 || busyYDiag[c+r]!=0) {
                    continue;
                }
                if (current==n-1) {
                    result++;
                }
                else {
                    current++;
                    Mark(r, c, 1);
                    Dfs(r+1);
                    Mark(r, c, -1);
                    current--;
                }
            }
        }
    }
    private void Mark(int r, int c, int d)
    {
        busyRows[r] += d;
        busyCols[c] += d;
        busyXDiag[c-r+n] += d;
        busyYDiag[c+r] += d;
    }
}
