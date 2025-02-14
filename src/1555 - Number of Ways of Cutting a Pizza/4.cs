// Copyright (c) 2024 Alexey Filatov
// 1555 - Number of Ways of Cutting a Pizza (https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza)
// Date solved: 11/5/2024 5:23:19 AM +00:00
// Memory: 40.5 MB
// Runtime: 8 ms


public class Solution {
    public int Ways(string[] pizza, int k) {
        var mod = 1000000007;
        var rows = pizza.Length;
        var cols = pizza[0].Length;
        var prefSum = new int[rows+1,cols+1]; // boundary will be 0
        for(var r = rows-1; r>=0; r--) {
            for(var c = cols-1; c>=0; c--) {
                prefSum[r,c] = prefSum[r+1, c] + prefSum[r, c+1] - prefSum[r+1, c+1] + (pizza[r][c]=='A' ? 1 : 0);
            }
        }
        var dp = new int[k, rows, cols]; // number of way cutting pizza from (r,c) with c cuts remaining

        // base - 0 cuts remaining
        for(var r = 0; r<rows; r++) {
            for(var c = 0; c<cols; c++) {
                dp[0, r, c] = prefSum[r,c]>0 ? 1 : 0;
            }
        }

        for(var m = 1; m<k; m++) {
            for(var r=0; r<rows; r++) {
                for(var c=0; c<cols; c++) {
                    // row cuts
                    for(var ir = r+1; ir<rows; ir++) {
                        if (prefSum[r,c] - prefSum[ir,c] > 0) {
                            dp[m, r, c] = (dp[m, r, c] + dp[m-1, ir, c]) % mod;
                        }
                    }
                    // column cuts
                    for(var ic=c+1; ic<cols; ic++) {
                        if (prefSum[r,c] - prefSum[r, ic] > 0) {
                            dp[m, r, c] = (dp[m, r, c] + dp[m-1, r, ic]) % mod;
                        }
                    }
                }
            }
        }

        return dp[k-1, 0, 0];
    }
}
