// Copyright (c) 2020 Alexey Filatov
// 329 - Longest Increasing Path in a Matrix (https://leetcode.com/problems/longest-increasing-path-in-a-matrix)
// Date solved: 3/30/2020 6:20:31 AM +00:00
// Memory: 28.8 MB
// Runtime: 128 ms


    public class Solution
    {
        private int[][] cache;
        private int[][] matrix;
        private int n;
        private int m;
        
        public int LongestIncreasingPath(int[][] matrix)
        {
            this.matrix = matrix;
            n = matrix.Length;
            if (n == 0) return 0;
            m = matrix[0].Length;

            cache = new int[n][];
            for (var r = 0; r < n; r++) cache[r] = new int[m];
            
            var result = 0;

            for (var r = 0; r < n; r++) {
                for (var c = 0; c < m; c++) {
                    result = Math.Max(result, DFS(r, c));
                }
            }

            return result;
        }

        private (int R, int C)[] allMoves = {
            (0, -1),
            (-1, 0),
            (0, 1),
            (1, 0)
        };

        int DFS(int r, int c)
        {
            if (cache[r][c]!=0) return cache[r][c];
            
            var maxLen = 1;
            
            foreach(var move in allMoves) {
                var nr = r + move.R;
                var nc = c + move.C;
                if (nr < 0 || nr >= n) continue;
                if (nc < 0 || nc >= m) continue;
                if (matrix[nr][nc] <= matrix[r][c]) continue;
                var len = 1 + DFS(nr, nc);
                maxLen = Math.Max(maxLen, len);
            }
            
            cache[r][c] = maxLen;
            return maxLen;
        }
    }

