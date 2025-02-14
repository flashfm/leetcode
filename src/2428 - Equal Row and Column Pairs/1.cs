// Copyright (c) 2024 Alexey Filatov
// 2428 - Equal Row and Column Pairs (https://leetcode.com/problems/equal-row-and-column-pairs)
// Date solved: 11/11/2024 7:50:34 PM +00:00
// Memory: 87.2 MB
// Runtime: 156 ms


public class Solution { 
    public int EqualPairs(int[][] grid) {
        var len = 25;
        var allOnes = BigInteger.Zero;
        for(var i = 0; i<len*8; i++) {
            allOnes |= BigInteger.One << i;
        }
        var n = grid.Length;
        var indexesByNumsByRow = new Dictionary<int, BigInteger>[n];
        for(var r=0; r<n; r++) {
            var row = grid[r];
            var dict = indexesByNumsByRow[r] = new Dictionary<int, BigInteger>();
            for(var c=0; c<n; c++) {
                var val = row[c];
                if (!dict.TryGetValue(val, out var indexes)) {
                    indexes = BigInteger.Zero;
                }
                dict[val] = indexes | (BigInteger.One << c);
            }
        }
        var result = 0;
        for(var r=0; r<n; r++) {
            var row = grid[r];
            var cur = allOnes;
            for(var c=0; c<n; c++) {
                var val = row[c];
                if (!indexesByNumsByRow[c].TryGetValue(val, out var indexes)) {
                    indexes = 0;
                }
                cur &= indexes;
                if (cur==0) {
                    break;
                }
            }
            result += (int)BigInteger.PopCount(cur);
        }
        return result;
    }
}
