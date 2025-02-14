// Copyright (c) 2024 Alexey Filatov
// 967 - Minimum Falling Path Sum (https://leetcode.com/problems/minimum-falling-path-sum)
// Date solved: 12/19/2024 5:39:55 AM +00:00
// Memory: 45.3 MB
// Runtime: 9 ms


public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        var n = matrix.Length;
        var cur = new int[n];
        var prev = new int[n];
        foreach(var row in matrix) {
            for(var i=0; i<n; i++) {
                cur[i] = row[i] + Math.Min(i-1>=0 ? prev[i-1] : int.MaxValue, Math.Min(prev[i], i+1<n ? prev[i+1] : int.MaxValue));
            }
            (cur, prev) = (prev, cur);
        }
        return prev.Min();
    }
}
