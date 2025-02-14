// Copyright (c) 2019 Alexey Filatov
// 73 - Set Matrix Zeroes (https://leetcode.com/problems/set-matrix-zeroes)
// Date solved: 12/19/2019 8:40:56 AM +00:00
// Memory: 32.5 MB
// Runtime: 268 ms


public class Solution {
    public void SetZeroes(int[][] matrix) {
      
      var resetFirstColumn = false;
      
      for(var r=0;r<matrix.Length;r++) {
        
        var row = matrix[r];
        
        if (row[0]==0) {
          resetFirstColumn = true;
        }
        
        for(var c = 1;c<row.Length;c++) {
          
          if (matrix[r][c]==0) {
            matrix[r][0] = 0;
            matrix[0][c] = 0;
          }
          
        }
      }
      
      for(var r=1;r<matrix.Length;r++) {
        var row = matrix[r];
        for(var c = 1;c<row.Length;c++) {
          if (row[0]==0 || matrix[0][c]==0) {
            row[c]=0;
          }
        }
      }

      var firstRow = matrix[0];
      if (firstRow[0]==0) {
        for(var c = 0;c<firstRow.Length;c++) {
          firstRow[c] = 0;
        }        
      }
      
      if (resetFirstColumn) {
        for(var r=0;r<matrix.Length;r++) {
          matrix[r][0] = 0;
        }        
      }

    }

}
