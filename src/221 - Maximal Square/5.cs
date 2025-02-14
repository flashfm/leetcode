// Copyright (c) 2024 Alexey Filatov
// 221 - Maximal Square (https://leetcode.com/problems/maximal-square)
// Date solved: 10/17/2024 7:29:39 PM +00:00
// Memory: 70.8 MB
// Runtime: 3 ms


public class Solution {
    public int MaximalSquare(char[][] matrix) {
        var n = matrix.Length;
        var m = matrix[0].Length;
        var max = 0;
        
        var prevRow = new int[m];
        var row = new int[m];
        for(var r = n-1; r>=0; r--) {
            for(var c = m-1; c>=0; c--) {
                row[c] = matrix[r][c]=='0' ? 0 : r==n-1 || c==m-1 ? 1 : Math.Min(prevRow[c+1], Math.Min(prevRow[c], row[c+1]))+1;
                max = Math.Max(max, row[c]);
            }
            var tmp = row;
            row = prevRow;
            prevRow = tmp;
        }

        return max*max;
    }
}
