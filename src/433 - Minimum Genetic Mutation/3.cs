// Copyright (c) 2024 Alexey Filatov
// 433 - Minimum Genetic Mutation (https://leetcode.com/problems/minimum-genetic-mutation)
// Date solved: 10/6/2024 11:54:10 PM +00:00
// Memory: 40.3 MB
// Runtime: 62 ms


public class Solution {
    public int MinMutation(string startGene, string endGene, string[] bank) {
        var queue = new Queue<(string, int)>();
        var visited = new HashSet<string>();
        queue.Enqueue((startGene, 0));
        while(queue.Count>0) {
            var (n, wave) = queue.Dequeue();
            var nexts = bank.Where(b => !visited.Contains(b) && b.Select((c,i) => n[i]==c ? 0 : 1).Sum()==1).ToArray();
            //Console.WriteLine($"{n} -> {(string.Join(",", nexts))}");
            foreach(var next in nexts) {
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
