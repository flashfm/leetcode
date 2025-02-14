// Copyright (c) 2024 Alexey Filatov
// 547 - Number of Provinces (https://leetcode.com/problems/number-of-provinces)
// Date solved: 11/15/2024 7:51:09 PM +00:00
// Memory: 49.5 MB
// Runtime: 2 ms


public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var n = isConnected.Length;
        var result = 0;
        var visited = new bool[n];
        for(var i = 0; i<n; i++) {
            if (!visited[i]) {
                Bfs(i);
                result++;
            }
        }
        return result;

        void Bfs(int a)
        {
            var queue = new Queue<int>();
            queue.Enqueue(a);
            visited[a] = true;
            while(queue.Count>0) {
                var i = queue.Dequeue();
                for(var j=0; j<n; j++) {
                    if (isConnected[i][j]==1 && !visited[j]) {
                        visited[j] = true;
                        queue.Enqueue(j);
                    }
                }
            }
        }
    }
}
