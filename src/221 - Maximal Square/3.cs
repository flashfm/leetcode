// Copyright (c) 2024 Alexey Filatov
// 221 - Maximal Square (https://leetcode.com/problems/maximal-square)
// Date solved: 10/17/2024 6:52:24 PM +00:00
// Memory: 76.7 MB
// Runtime: 424 ms


public class Solution {
    public int MaximalSquare(char[][] matrix) {
        var n = matrix.Length;
        var m = matrix[0].Length;
        var maxSize = Math.Min(m, n);
        var dp = new bool[n, m, maxSize+1];
        var result = 0;
        for(var size = 1; size<=maxSize; size++) {
            for(var r = 0; r+size<=n; r++) {
                for(var c = 0; c+size<=m; c++) {
                    var subSize = size/2 + size%2;
                    var shift = size/2;
                    dp[r, c, size] = size==1 ? matrix[r][c] == '1' : matrix[r][c] == '1' && dp[r, c, subSize] && dp[r+shift, c, subSize] && dp[r, c+shift, subSize] && dp[r+shift, c+shift, subSize];
                    if (dp[r, c, size]) {
                        result = size;
                    }
                }
            }

        }
        return result*result;
    }
}
