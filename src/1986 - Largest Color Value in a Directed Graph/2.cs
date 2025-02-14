// Copyright (c) 2024 Alexey Filatov
// 1986 - Largest Color Value in a Directed Graph (https://leetcode.com/problems/largest-color-value-in-a-directed-graph)
// Date solved: 10/21/2024 8:04:08 AM +00:00
// Memory: 203.8 MB
// Runtime: 915 ms


public class Solution {
    int result = -1;
    string colors;
    Dictionary<int, List<int>> tosByNode = new();
    HashSet<int> visited = [];
    Dictionary<int, Dictionary<char, int>> freqByNode = new();
    bool cycle;

    public int LargestPathValue(string colors, int[][] edges) {
        this.colors = colors;
        var n = colors.Length;
        foreach(var e in edges) {
            var from = e[0];
            var to = e[1];
            (tosByNode.GetValueOrDefault(from) ?? (tosByNode[from] = new List<int>())).Add(to);
        }
        for(var i = 0; i<n; i++) {
            if (!freqByNode.ContainsKey(i)) {
                Dfs(i);
            }
            if (cycle) {
                break;
            }
        }
        return cycle ? -1 : result;
    }

    private void Dfs(int node)
    {
        if (cycle) {
            return;
        }
        var color = colors[node];
        visited.Add(node);

        if (!freqByNode.TryGetValue(node, out var freq)) {
            freqByNode[node] = freq = new Dictionary<char, int>();

            var tos = tosByNode.GetValueOrDefault(node) ?? Enumerable.Empty<int>();
            foreach(var to in tos) {
                if (visited.Contains(to)) {
                    cycle = true;
                    break;
                }
                Dfs(to);
                foreach(var (c, cnt) in freqByNode[to]) {
                    freq[c] = Math.Max(cnt, freq.GetValueOrDefault(c));
                }
            }

            freq[color] = freq.GetValueOrDefault(color) + 1;
            result = Math.Max(result, freq[color]);
        }

        visited.Remove(node);
    }
}
