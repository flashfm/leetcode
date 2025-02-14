// Copyright (c) 2020 Alexey Filatov
// 329 - Longest Increasing Path in a Matrix (https://leetcode.com/problems/longest-increasing-path-in-a-matrix)
// Date solved: 3/30/2020 5:48:40 AM +00:00
// Memory: 30.2 MB
// Runtime: 320 ms


    public class Solution
    {
        private int[][] wasAtPosition;
        private int[][] matrix;
        private int n;
        private int m;
        
        public int LongestIncreasingPath(int[][] matrix)
        {
            this.matrix = matrix;
            n = matrix.Length;
            if (n == 0) return 0;
            m = matrix[0].Length;

            wasAtPosition = new int[n][];
            for (var r = 0; r < n; r++) wasAtPosition[r] = new int[m];
            
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

        class Item
        {
            public int R;
            public int C;
            public int Pos;

            public Item(int r, int c, int pos)
            {
                R = r;
                C = c;
                Pos = pos;
            }
        }

        int DFS(int r, int c)
        {
            var maxLen = 0;
            
            var stack = new Stack<Item>();
            stack.Push(new Item(r, c, 0));
            
            while (stack.Count > 0) {
                maxLen = Math.Max(maxLen, stack.Count);

                var top = stack.Peek();
                var nextPos = top.Pos;
                var moves = GetMoves(top.R, top.C).OrderBy(i => i.Value).ToArray();
                while (nextPos < moves.Length) {
                    var move = moves[nextPos];
                    if (wasAtPosition[move.R][move.C] >= stack.Count) nextPos++;
                    else break;
                }
                // since we order, we will remember an index from that order
                if (nextPos < moves.Length) {
                    top.Pos++;
                    // move forward to moves[nextPos]
                    var move = moves[nextPos];
                    stack.Push(new Item(move.R, move.C, 0));
                    wasAtPosition[move.R][move.C] = stack.Count - 1;
                }
                else {
                    // move back
                    stack.Pop();
                }
            }

            return maxLen;
        }
        
        // returns possible increasing moves (using which move and to which value)
        private IEnumerable<(int R, int C, int Value)> GetMoves(int r, int c)
        {
            var x = matrix[r][c];
            for (var i = 0; i < allMoves.Length; i++) {
                var move = allMoves[i];
                var nr = r + move.R;
                var nc = c + move.C;
                if (nr < 0 || nr >= n) continue;
                if (nc < 0 || nc >= m) continue;
                var y = matrix[nr][nc];
                if (y > x) {
                    yield return (nr, nc, y);
                }
            }
        }
    }

