// Copyright (c) 2024 Alexey Filatov
// 399 - Evaluate Division (https://leetcode.com/problems/evaluate-division)
// Date solved: 10/6/2024 6:35:57 PM +00:00
// Memory: 46 MB
// Runtime: 125 ms


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
            var visited = new HashSet<string>() {q[0]};
            results.Add(Dfs(q[0], q[1], visited));
        }
        return results.ToArray();
    }

    private double Dfs(string from, string to, HashSet<string> visited)
    {
        var tos = graph.GetValueOrDefault(from);
        if (tos==null) {
            return -1;
        }
        if (tos.TryGetValue(to, out var v)) {
            return v;
        }
        foreach(var (x, val) in tos) {
            if (visited.Contains(x)) {
                continue;
            }
            visited.Add(x);
            var sub = Dfs(x, to, visited);
            visited.Remove(x);
            if (sub != -1) {
                return sub * val;
            }
        }
        return -1;
    }
}
