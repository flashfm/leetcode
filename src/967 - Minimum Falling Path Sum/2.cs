// Copyright (c) 2024 Alexey Filatov
// 967 - Minimum Falling Path Sum (https://leetcode.com/problems/minimum-falling-path-sum)
// Date solved: 12/19/2024 5:43:50 AM +00:00
// Memory: 45.9 MB
// Runtime: 6 ms


public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        var n = matrix.Length;
        for(var r=1; r<n; r++) {
            for(var i=0; i<n; i++) {
                matrix[r][i] += Math.Min(i-1>=0 ? matrix[r-1][i-1] : int.MaxValue, Math.Min(matrix[r-1][i], i+1<n ? matrix[r-1][i+1] : int.MaxValue));
            }
        }
        return matrix[n-1].Min();
    }
}
