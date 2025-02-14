// Copyright (c) 2024 Alexey Filatov
// 1555 - Number of Ways of Cutting a Pizza (https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza)
// Date solved: 11/5/2024 3:22:43 AM +00:00
// Memory: 41.8 MB
// Runtime: 76 ms


public class Solution {
    public int Ways(string[] pizza, int k) {
        if (k==1) {
            return pizza.Any(r => r.Any(c => c=='A')) ? 1 : 0;
        }
        var rows = pizza.Length;
        var cols = pizza[0].Length;
        var hasAppleAtOrDownRight = new bool[rows, cols];
        var hasAppleInRowStartingCol = new bool[rows, cols];
        var hasAppleInColStartingRow = new bool[rows, cols];
        for(var r = rows-1; r>=0; r--) {        
            for(var c = cols-1; c>=0; c--) {
                hasAppleAtOrDownRight[r, c] = pizza[r][c]=='A' || 
                    (c+1<cols && hasAppleAtOrDownRight[r, c+1]) ||
                    (r+1<rows && hasAppleAtOrDownRight[r+1, c]);

                hasAppleInRowStartingCol[r, c] = pizza[r][c]=='A' ||
                    (c+1<cols && hasAppleInRowStartingCol[r, c+1]);

                hasAppleInColStartingRow[r, c] = pizza[r][c]=='A' ||
                    (r+1<rows && hasAppleInColStartingRow[r+1, c]);
            }
        }

        var cache = new Dictionary<(int, int, int), long>();
        var x = Cut(0, 0, k);
        return (int)(x % 1000000007);

        long Cut(int r, int c, int pieces)
        {
            if (r==rows || c==cols) {
                return 0;
            }
            if (!cache.TryGetValue((r, c, pieces), out var result)) {
                cache[(r, c, pieces)] = result = CutRow(r, c, pieces) + CutCol(r, c, pieces);
            }
            return result;
        }

        long CutRow(int startRow, int c, int pieces)
        {
            long result = 0;
            var hasApplesInCut = false;
            for(var r=startRow; r<rows; r++) {
                if (hasApplesInCut || hasAppleInRowStartingCol[r, c]) {
                    hasApplesInCut = true;
                    if (r+1<rows && hasAppleAtOrDownRight[r+1, c]) {
                        result += pieces==2 ? 1 : Cut(r+1, c, pieces-1);
                    }
                }
            }
            return result;
        }

        long CutCol(int r, int startCol, int pieces) 
        {
            long result = 0;
            var hasApplesInCut = false;
            for(var c=startCol; c<cols; c++) {
                if (hasApplesInCut || hasAppleInColStartingRow[r, c]) {
                    hasApplesInCut = true;
                    if (c+1<cols && hasAppleAtOrDownRight[r, c+1]) {
                        result += pieces==2 ? 1 : Cut(r, c+1, pieces-1);
                    }
                }
            }
            return result;
        }
    }
}
