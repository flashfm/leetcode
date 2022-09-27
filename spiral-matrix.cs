// Spiral Matrix
// https://leetcode.com/problems/spiral-matrix
// Date solved: 02/06/2020 06:47:49 +00:00

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        var n = matrix.Length;
        if (n==0) return result;
        var m = matrix[0].Length;
        if (m==0) return result;
        int[] deltas = {0,1,0,-1};
        var rp = 0;
        var cp = 1;
        var r = 0; // row
        var c = 0; // col
        for(var i=0;i<n*m;i++) {
            result.Add(matrix[r][c]);
            matrix[r][c] = int.MinValue;           
            var nr = r + deltas[rp];
            var nc = c + deltas[cp];            
            if (ShouldTurn(nr, nc, matrix)) {
                rp = (rp+1) % deltas.Length;
                cp = (cp+1) % deltas.Length;            
            }
            r += deltas[rp];
            c += deltas[cp];       
        }
        return result;
    }
    private bool ShouldTurn(int nr, int nc, int[][] matrix) => nr>matrix.Length-1 || nr<0 || nc>matrix[0].Length-1 || nc<0 || matrix[nr][nc]==int.MinValue;
}
