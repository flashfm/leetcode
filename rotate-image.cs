// Rotate Image
// https://leetcode.com/problems/rotate-image
// Date solved: 10/04/2020 00:04:55 +00:00

public class Solution {
    private int[][] matrix;
    private int n;
    public void Rotate(int[][] matrix) {
        this.matrix = matrix;
        n = matrix.Length;
        for(var r=0; r<n/2; r++) {
            var right = n-1-r;
            for(var c = r; c<right; c++) {
                swap(r, c, c, right);
                swap(r, c, right, right-(c-r));
                swap(r, c, right-(c-r), r);
            }
        }
    }
    private void swap(int r, int c, int r1, int c1)
    {
        if (r>=n || c>=n || r1>=n || c1>=n) {
            return;
        }
        var tmp = matrix[r][c];
        matrix[r][c] = matrix[r1][c1];
        matrix[r1][c1] = tmp;
    }
}
