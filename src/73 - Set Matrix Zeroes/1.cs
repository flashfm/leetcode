// Copyright (c) 2019 Alexey Filatov
// 73 - Set Matrix Zeroes (https://leetcode.com/problems/set-matrix-zeroes)
// Date solved: 12/19/2019 8:18:14 AM +00:00
// Memory: 32.6 MB
// Runtime: 280 ms


public class Solution {
    public void SetZeroes(int[][] matrix) {
        var storageRowsDefined = false;    
        var storageRowIndex = 0;
        var storageColumnIndex = 0;
      
        for(var r=0;r<matrix.Length;r++) {
          var row = matrix[r];
          for(var c=0;c<row.Length;c++) {
            if (row[c]==0) {
              if (!storageRowsDefined) {
                storageRowsDefined = true;
                storageRowIndex = r;
                storageColumnIndex = c;
                SetRowToZeros(matrix, r, true);
                SetColumnToZeros(matrix, c, true);
              }
                            
              matrix[storageRowIndex][c] = 1;
              matrix[r][storageColumnIndex] = 1;              
            }
          }
        }
      
      if (storageRowsDefined) {
      var storageRow = matrix[storageRowIndex];
      for(var i=0;i<storageRow.Length;i++) {
        if (i!=storageColumnIndex && storageRow[i]==1) {
          SetColumnToZeros(matrix, i, false);
        }
      }
      for(var i=0;i<matrix.Length;i++) {
        var row = matrix[i];
        if (row[storageColumnIndex]==1) {
          SetRowToZeros(matrix, i, false);
        }
      }
      SetColumnToZeros(matrix, storageColumnIndex, false);
      SetRowToZeros(matrix, storageRowIndex, false);
      }
    }
  void SetRowToZeros(int[][] matrix, int rowIndex, bool zeroToOne)
  {
    var row = matrix[rowIndex];    
          for(var c=0;c<row.Length;c++) {
            if (zeroToOne) {
              if (row[c]==0) row[c]=1; else row[c]=2;
            }
            else {
              row[c]=0;
            }
          }
  }
  void SetColumnToZeros(int[][] matrix, int columnIndex, bool zeroToOne)
  {
        for(var r=0;r<matrix.Length;r++) {
          var row = matrix[r];
          if (zeroToOne) {
            if (row[columnIndex]==0) row[columnIndex]=1; else row[columnIndex]=2;
          }
          else {
            row[columnIndex] = 0;          
          }
        }    
  }
}
