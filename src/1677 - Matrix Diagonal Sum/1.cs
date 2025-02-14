// Copyright (c) 2024 Alexey Filatov
// 1677 - Matrix Diagonal Sum (https://leetcode.com/problems/matrix-diagonal-sum)
// Date solved: 12/18/2024 2:43:48 AM +00:00
// Memory: 44.8 MB
// Runtime: 0 ms


public class Solution {
    public int DiagonalSum(int[][] mat) {
        var sum = 0;
        var n = mat.Length;
        for(var i=0; i<n; i++) {
            sum += mat[i][i] + mat[i][n-1-i];
        }
        if (n%2==1) {
            sum -= mat[n/2][n/2];
        }
        return sum;
    }
}
