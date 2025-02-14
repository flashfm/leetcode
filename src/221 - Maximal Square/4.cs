// Copyright (c) 2024 Alexey Filatov
// 221 - Maximal Square (https://leetcode.com/problems/maximal-square)
// Date solved: 10/17/2024 7:24:48 PM +00:00
// Memory: 71.8 MB
// Runtime: 11 ms


public class Solution {
    public int MaximalSquare(char[][] matrix) {
        var n = matrix.Length;
        var m = matrix[0].Length;
        var dp = new int[n,m];
        var max = 0;
        
        for(var r = n-1; r>=0; r--) {
            for(var c = m-1; c>=0; c--) {
                dp[r,c] = matrix[r][c]=='0' ? 0 : r==n-1 || c==m-1 ? 1 : Math.Min(dp[r+1, c+1], Math.Min(dp[r+1, c], dp[r, c+1]))+1;
                max = Math.Max(max, dp[r,c]);
            }
        }

        return max*max;
    }
}
