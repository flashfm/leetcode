// Copyright (c) 2024 Alexey Filatov
// 52 - N-Queens II (https://leetcode.com/problems/n-queens-ii)
// Date solved: 10/10/2024 3:41:46 AM +00:00
// Memory: 26.8 MB
// Runtime: 177 ms


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
    private void Dfs(int start)
    {
        for(var i = start; i<n*n; i++) {
            var r = i / n;
            var c = i % n;
            if (busyRows[r]!=0 || busyCols[c]!=0 || busyXDiag[c-r+n]!=0 || busyYDiag[c+r]!=0) {
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
        busyRows[r] += d;
        busyCols[c] += d;
        busyXDiag[c-r+n] += d;
        busyYDiag[c+r] += d;
    }
}
