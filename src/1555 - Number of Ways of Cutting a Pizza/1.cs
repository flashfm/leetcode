// Copyright (c) 2024 Alexey Filatov
// 1555 - Number of Ways of Cutting a Pizza (https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza)
// Date solved: 11/5/2024 2:13:49 AM +00:00
// Memory: 42.3 MB
// Runtime: 74 ms


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
        var cache = new Dictionary<(int, int, int), long>();
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

        var x = Cut(0, 0, k);
        return (int)(x % 1000000007);

        long Cut(int startRow, int startCol, int kk)
        {
            if (startRow==rows || startCol==cols) {
                return 0;
            }
            if (!cache.TryGetValue((startRow, startCol, kk), out var result)) {
                cache[(startRow, startCol, kk)] = result = CutRow(startRow, startCol, kk) + CutCol(startRow, startCol, kk);
            }
            return result;
        }

        long CutRow(int startRow, int startCol, int kk)
        {
            long result = 0;
            var hasApplesInCut = false;
            for(var r=startRow; r<rows; r++) {
                if (hasApplesInCut || hasAppleInRowStartingCol[r, startCol]) {
                    hasApplesInCut = true;
                    if (r+1<rows && hasAppleAtOrDownRight[r+1, startCol]) {
                        result += kk==2 ? 1 : Cut(r+1, startCol, kk-1);
                    }
                }
            }
            return result;
        }

        long CutCol(int startRow, int startCol, int kk) 
        {
            long result = 0;
            var hasApplesInCut = false;
            for(var c=startCol; c<cols; c++) {
                if (hasApplesInCut || hasAppleInColStartingRow[startRow, c]) {
                    hasApplesInCut = true;
                    if (c+1<cols && hasAppleAtOrDownRight[startRow, c+1]) {
                        result += kk==2 ? 1 : Cut(startRow, c+1, kk-1);
                    }
                }
            }
            return result;
        }
    }
}
