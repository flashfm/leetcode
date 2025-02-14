// Copyright (c) 2024 Alexey Filatov
// 1986 - Largest Color Value in a Directed Graph (https://leetcode.com/problems/largest-color-value-in-a-directed-graph)
// Date solved: 10/22/2024 1:13:16 AM +00:00
// Memory: 113.4 MB
// Runtime: 641 ms


public class Solution {

    public int LargestPathValue(string colors, int[][] edges) {
        var result = -1;
        var n = colors.Length;
        var incomings = new int[n];
        var freqByNode = new int[n, 26];
        var tosByNode = new Dictionary<int, List<int>>();
        var seen = 0;
        foreach(var e in edges) {
            var from = e[0];
            var to = e[1];
            (tosByNode.GetValueOrDefault(from) ?? (tosByNode[from] = new List<int>())).Add(to);
            incomings[to]++;
        }
        var queue = new Queue<int>();
        for(var i = 0; i<n; i++) {
            if (incomings[i]==0) {
                queue.Enqueue(i);
                freqByNode[i, colors[i] - 'a'] = 1;
            }
        }
        while(queue.Count>0) {
            var node = queue.Dequeue();
            result = Math.Max(result, GetMaxColor(node));
            var tos = tosByNode.GetValueOrDefault(node) ?? Enumerable.Empty<int>();
            seen++;
            foreach(var to in tos) {
                for(var c = 0; c<26; c++) {
                    freqByNode[to, c] = Math.Max(freqByNode[to, c], freqByNode[node, c] + ((colors[to]-'a') == c ? 1 : 0));
                }
                if (--incomings[to]==0) {
                    queue.Enqueue(to);
                }
            }
        }
        return seen<n ? -1 : result;

        int GetMaxColor(int node)
        {
            var max = int.MinValue;
            for(var c = 0; c<26; c++) {
                max = Math.Max(max, freqByNode[node, c]);
            }
            return max;
        }
    }
}
