// Copyright (c) 2024 Alexey Filatov
// 399 - Evaluate Division (https://leetcode.com/problems/evaluate-division)
// Date solved: 10/6/2024 6:44:28 PM +00:00
// Memory: 46.5 MB
// Runtime: 93 ms


public class Solution {
    private Dictionary<string, Dictionary<string, double>> graph = new();

    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        for(var i = 0; i<equations.Count; i++) {
            var pair = equations[i];
            var val = values[i];
            var from = pair[0];
            var to = pair[1];
            (graph[from] = graph.GetValueOrDefault(from) ?? new Dictionary<string, double>())[to] = val;
            (graph[to] = graph.GetValueOrDefault(to) ?? new Dictionary<string, double>())[from] = 1/val;
        }
        var results = new List<double>();
        foreach(var q in queries) {
            results.Add(Bfs(q[0], q[1]));
        }
        return results.ToArray();
    }

    private double Bfs(string from, string to)
    {
        var visited = new HashSet<string>() {from};
        var queue = new Queue<(string, double)>();
        queue.Enqueue((from, 1));
        while(queue.Count>0) {
            var (cur, cost) = queue.Dequeue();
            var tos = graph.GetValueOrDefault(cur);
            if (tos!=null) {
                if (cur==to) {
                    return cost;
                }
                foreach(var (x, val) in tos) {
                    if (visited.Contains(x)) {
                        continue;
                    }
                    visited.Add(x);
                    queue.Enqueue((x, val*cost));
                }
            }
        }
        return -1;
    }
}
