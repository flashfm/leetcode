// Copyright (c) 2024 Alexey Filatov
// 1576 - Reorder Routes to Make All Paths Lead to the City Zero (https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero)
// Date solved: 11/16/2024 12:07:14 AM +00:00
// Memory: 94.2 MB
// Runtime: 87 ms


public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var outgoingByNode = new Dictionary<int, List<int>>();
        var incomingByNode = new Dictionary<int, List<int>>();
        foreach(var conn in connections) {
            var from = conn[0];
            var to = conn[1];
            (outgoingByNode.GetValueOrDefault(from) ?? (outgoingByNode[from] = new List<int>())).Add(to);
            (incomingByNode.GetValueOrDefault(to) ?? (incomingByNode[to] = new List<int>())).Add(from);
        }
        var result = 0;
        var queue = new Queue<int>();
        var visited = new bool[n];
        queue.Enqueue(0);
        visited[0] = true;
        while(queue.Count>0) {
            var i = queue.Dequeue();
            foreach(var inc in incomingByNode.GetValueOrDefault(i) ?? Enumerable.Empty<int>()) {
                if (!visited[inc]) {
                    visited[inc] = true;
                    queue.Enqueue(inc);
                }
            }
            foreach(var outg in outgoingByNode.GetValueOrDefault(i) ?? Enumerable.Empty<int>()) {
                if (!visited[outg]) {
                    result++;
                    visited[outg] = true;
                    queue.Enqueue(outg);
                }
            }
        }
        return result;
    }
}
