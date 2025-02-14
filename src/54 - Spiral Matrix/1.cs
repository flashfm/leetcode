// Copyright (c) 2020 Alexey Filatov
// 54 - Spiral Matrix (https://leetcode.com/problems/spiral-matrix)
// Date solved: 2/6/2020 6:44:09 AM +00:00
// Memory: 29.9 MB
// Runtime: 244 ms


public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        if (matrix.Length==0 || matrix[0].Length==0) return result;
        int[] deltas = {0,1,0,-1};
        var rp = 0;
        var cp = 1;
        var r = 0; // row
        var c = 0; // col
        while(true) {
            result.Add(matrix[r][c]);
            matrix[r][c] = int.MinValue;
            
            var nr = r + deltas[rp];
            var nc = c + deltas[cp];            
            if (ShouldTurn(nr, nc, matrix)) {
                rp = (rp+1) % deltas.Length;
                cp = (cp+1) % deltas.Length;            
                nr = r + deltas[rp];
                nc = c + deltas[cp];       
            }
            if (ShouldTurn(nr, nc, matrix)) {
                break;
            }
            r = nr;
            c = nc;
        }
        return result;
    }
    private bool ShouldTurn(int nr, int nc, int[][] matrix) => nr>matrix.Length-1 || nr<0 || nc>matrix[0].Length-1 || nc<0 || matrix[nr][nc]==int.MinValue;
}
