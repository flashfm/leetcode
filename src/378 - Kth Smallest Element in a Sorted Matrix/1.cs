// Copyright (c) 2022 Alexey Filatov
// 378 - Kth Smallest Element in a Sorted Matrix (https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix)
// Date solved: 10/10/2022 4:37:13 AM +00:00
// Memory: 41.3 MB
// Runtime: 211 ms


public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        var n = matrix.Length;
        var low = matrix[0][0];
        var high = matrix[n-1][n-1];
        var result = 0;
        while(low <= high) {
            var mid = low + (high - low) / 2;
            var x = getNumberOfElementsLessOrEqual(matrix, mid);
            if (x>=k) {
                result = mid;
                high = mid-1;
            }
            else {
                low = mid+1;
            }
        }
        return result;
    }

    private int getNumberOfElementsLessOrEqual(int[][] matrix, int mid)
    {
        var result = 0;
        var n = matrix.Length;
        var row = n-1;
        var col = 0;
        while(row>=0 && col<n) {
            if (matrix[row][col]>mid) {
                row--;
            }
            else {
                result += row+1;
                col++;
            }
        }
        return result;
    }
}
