// Copyright (c) 2024 Alexey Filatov
// 433 - Minimum Genetic Mutation (https://leetcode.com/problems/minimum-genetic-mutation)
// Date solved: 10/6/2024 11:53:17 PM +00:00
// Memory: 40.4 MB
// Runtime: 69 ms


public class Solution {
    public int MinMutation(string startGene, string endGene, string[] bank) {
        var graph = new Dictionary<string, string[]>();
        foreach(var n in bank.Union(Enumerable.Repeat(startGene, 1))) {
            graph[n] = bank.Where(b => b.Select((c,i) => n[i]==c ? 0 : 1).Sum()==1).ToArray();
        }
        var queue = new Queue<(string, int)>();
        var visited = new HashSet<string>();
        queue.Enqueue((startGene, 0));
        while(queue.Count>0) {
            var (n, wave) = queue.Dequeue();
            var nexts = graph.GetValueOrDefault(n);
            //Console.WriteLine($"{n} -> {(string.Join(",", nexts))}");
            foreach(var next in nexts) {
                if (visited.Contains(next)) {
                    continue;
                }
                if (next==endGene) {
                    return wave+1;
                }
                visited.Add(next);
                queue.Enqueue((next, wave+1));
            }
        }
        return -1;
    }
}
