// Copyright (c) 2019 Alexey Filatov
// 73 - Set Matrix Zeroes (https://leetcode.com/problems/set-matrix-zeroes)
// Date solved: 12/19/2019 8:56:12 AM +00:00
// Memory: 32.8 MB
// Runtime: 268 ms


public class Solution {
    public void SetZeroes(int[][] matrix) {
      var n = matrix.Length;
      var m = matrix[0].Length;

      var resetFirstColumn = false;
      var resetFirstRow = false;

      for(var r=0;r<n;r++) {
        if (matrix[r][0]==0) {
          resetFirstColumn = true;
        }
      }
      for(var c=0;c<m;c++) {
        if (matrix[0][c]==0) {
          resetFirstRow = true;
        }
      }
      
      for(var r=0;r<n;r++) {
        for(var c=0;c<m;c++) {
          if (matrix[r][c]==0) {
            matrix[r][0] = 0;
            matrix[0][c] = 0;
          }
        }
      }
      
      for(var r=1;r<n;r++) {
        for(var c=1;c<m;c++) {
          if (matrix[r][0]==0 || matrix[0][c]==0) {
            matrix[r][c]=0;
          }
        }
      }

      if (resetFirstRow) {
        for(var c=0;c<m;c++) {
          matrix[0][c] = 0;
        }        
      }
      
      if (resetFirstColumn) {
        for(var r=0;r<n;r++) {
          matrix[r][0] = 0;
        }        
      }
    }

}
