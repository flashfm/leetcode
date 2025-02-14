// Copyright (c) 2020 Alexey Filatov
// 240 - Search a 2D Matrix II (https://leetcode.com/problems/search-a-2d-matrix-ii)
// Date solved: 2/5/2020 8:08:46 AM +00:00
// Memory: 31.4 MB
// Runtime: 364 ms


public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if (matrix.GetLength(0)==0 || matrix.GetLength(1)==0) return false;
        return BinSearch(matrix, 0, matrix.GetLength(0)-1, 0, matrix.GetLength(1)-1, target);
    }
    private bool BinSearch(int[,] matrix, int il, int ir, int jl, int jr, int target)
    {
        var origil = il;
        var origir = ir;
        var origjl = jl;
        var origjr = jr;
        while(il<=ir) {
            var im = (il+ir)/2;
            var jm = (jl+jr)/2;
            var m = matrix[im,jm];
            if (m==target) return true;
            if (target>m) {
                il = im+1;
                jl = jm+1;
            }
            else {
                ir = im-1;
                jr = jm-1;
            }
        }
        if (origil == il && origir == ir) return false;
        if (origjl == jl && origjr == jr) return false;
        if (BinSearch(matrix, origil, ir, jl, origjr, target)) return true;
        if (BinSearch(matrix, il, origir, origjl, jr, target)) return true;
        return false;
    }
}
