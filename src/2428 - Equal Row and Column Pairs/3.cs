// Copyright (c) 2024 Alexey Filatov
// 2428 - Equal Row and Column Pairs (https://leetcode.com/problems/equal-row-and-column-pairs)
// Date solved: 11/11/2024 8:46:22 PM +00:00
// Memory: 64.1 MB
// Runtime: 26 ms


public class Solution { 
    public int EqualPairs(int[][] grid) {
        var n = grid.Length;
        var colCountByCol = new Dictionary<string, int>();
        for(var c=0; c<n; c++) {
            var col = string.Join(",", Enumerable.Range(0, n).Select(r => grid[r][c]));
            colCountByCol[col] = colCountByCol.GetValueOrDefault(col) + 1;
        }
        var result = 0;
        foreach(var row in grid) {
            var s = string.Join(",", row);
            result += colCountByCol.GetValueOrDefault(s);
        }
        return result;
    }
}
