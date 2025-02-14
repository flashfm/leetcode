// Copyright (c) 2020 Alexey Filatov
// 240 - Search a 2D Matrix II (https://leetcode.com/problems/search-a-2d-matrix-ii)
// Date solved: 2/5/2020 8:16:14 AM +00:00
// Memory: 31.4 MB
// Runtime: 240 ms


public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if (matrix.GetLength(0)==0 || matrix.GetLength(1)==0) return false;
        var row = 0;
        var col = matrix.GetLength(1)-1;
        while(col>=0 && row<matrix.GetLength(0)) {
            var c = matrix[row,col];
            if (c==target) return true;
            else if (c>target) col--;
            else row++;
        }
        return false;
    }
}
