// Copyright (c) 2020 Alexey Filatov
// 815 - Champagne Tower (https://leetcode.com/problems/champagne-tower)
// Date solved: 10/30/2020 7:18:55 AM +00:00
// Memory: 32.3 MB
// Runtime: 56 ms


public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        var vol = new double[102, 102];
        vol[0, 0] = poured;
        for(var r = 0; r <= query_row; r++) {
            for(var c = 0; c <= r; c++) {
                var over = (vol[r, c] - 1) / 2;
                if (over>0) {
                    vol[r+1, c] += over;
                    vol[r+1, c+1] += over;
                }
            }
        }
        return Math.Min(1, vol[query_row, query_glass]);
    }
}
