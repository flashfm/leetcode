// Copyright (c) 2024 Alexey Filatov
// 1555 - Number of Ways of Cutting a Pizza (https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza)
// Date solved: 11/5/2024 4:53:33 AM +00:00
// Memory: 40.7 MB
// Runtime: 20 ms


public class Solution {
    public int Ways(string[] pizza, int k) {
        var rows = pizza.Length;
        var cols = pizza[0].Length;
        var prefSum = new int[rows+1,cols+1]; // boundary will be 0
        for(var r = rows-1; r>=0; r--) {
            for(var c = cols-1; c>=0; c--) {
                prefSum[r,c] = prefSum[r+1, c] + prefSum[r, c+1] - prefSum[r+1, c+1] + (pizza[r][c]=='A' ? 1 : 0);
            }
        }
        var cache = new long?[k, rows, cols];
        var x = Cut(0, 0, k-1);
        return (int)(x % 1000000007);

        long Cut(int r, int c, int cuts)
        {
            if (prefSum[r,c]==0) {
                // no apples in this rectangle
                return 0;
            }
            if (cuts==0) {
                return 1;
            }
            var cached = cache[cuts,r,c];
            if (cached!=null) {
                return cached.Value;
            }
            long result = 0;
            // rows
            for(var ir = r+1; ir<rows; ir++) {
                if (prefSum[r,c] - prefSum[ir,c] > 0) {
                    result += Cut(ir, c, cuts-1);
                }
            }
            // cols
            for(var ic=c+1; ic<cols; ic++) {
                if (prefSum[r,c] - prefSum[r, ic] > 0) {
                    result += Cut(r, ic, cuts-1);
                }
            }
            
            cache[cuts,r,c] = result;
            return result;
        }
    }
}
