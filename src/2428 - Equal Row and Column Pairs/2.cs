// Copyright (c) 2024 Alexey Filatov
// 2428 - Equal Row and Column Pairs (https://leetcode.com/problems/equal-row-and-column-pairs)
// Date solved: 11/11/2024 8:43:29 PM +00:00
// Memory: 92.9 MB
// Runtime: 122 ms


public class Solution { 
    class Comparer : EqualityComparer<int[]>
    {
        public override bool Equals(int[] x, int[] y)
            => StructuralComparisons.StructuralEqualityComparer.Equals(x, y);

        public override int GetHashCode(int[] x)
            => StructuralComparisons.StructuralEqualityComparer.GetHashCode(x);
    }    
    public int EqualPairs(int[][] grid) {
        var n = grid.Length;
        var colCountByCol = new Dictionary<int[], int>(new Comparer());
        for(var c=0; c<n; c++) {
            var colList = new List<int>();
            for(var r=0; r<n; r++) {
                colList.Add(grid[r][c]);
            }
            var col = colList.ToArray();
            colCountByCol[col] = colCountByCol.GetValueOrDefault(col) + 1;
        }
        var result = 0;
        foreach(var row in grid) {
            result += colCountByCol.GetValueOrDefault(row);
        }
        return result;
    }
}
