// Copyright (c) 2024 Alexey Filatov
// 945 - Snakes and Ladders (https://leetcode.com/problems/snakes-and-ladders)
// Date solved: 10/6/2024 7:47:20 PM +00:00
// Memory: 47.5 MB
// Runtime: 102 ms


public class Solution {
    private int[][] board;
    private int n;

    public int SnakesAndLadders(int[][] board) {
        this.board = board;
        this.n = board.Length;

        var dist = Enumerable.Repeat(int.MaxValue, n*n).ToArray();
        dist[0] = 0;
        var queue = new Queue<int>();
        queue.Enqueue(0);
        while(queue.Count>0) {
            var cur = queue.Dequeue();
            var curDist = dist[cur]+1;
            for(var next = cur+1; next<Math.Min(cur+7, n*n); next++) {
                var jump = GetJump(next);
                if (jump!=-1) {
                    if (curDist < dist[jump]) {
                        Console.WriteLine($"{cur}, {next}, {jump}");
                        dist[jump] = curDist;
                        queue.Enqueue(jump);
                    }
                }
                else {
                    if (curDist < dist[next]) {
                        dist[next] = curDist;
                        queue.Enqueue(next);
                    }
                }

            }
        }
        var result = dist[n*n-1];
        return result == int.MaxValue ? -1 : result;
    }

    private int GetJump(int next)
    {
        var r = next/n;
        var row = n-1-r;
        var col = next%n;
        if (r%2==1) {
            col = n-1 - col;
        }
        var jump = board[row][col];
        return jump==-1 ? jump : jump-1;
    }
}
