// Copyright (c) 2024 Alexey Filatov
// 332 - Reconstruct Itinerary (https://leetcode.com/problems/reconstruct-itinerary)
// Date solved: 10/21/2024 6:16:56 AM +00:00
// Memory: 60.8 MB
// Runtime: 6 ms


public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var destinationsByNode = new Dictionary<string, PriorityQueue<string, string>>();
        foreach(var t in tickets) {
            var from = t[0];
            var to = t[1];
            (destinationsByNode.GetValueOrDefault(from) ?? (destinationsByNode[from] = new PriorityQueue<string, string>())).Enqueue(to, to);
        }

        var path = new List<string>();

        Dfs("JFK");

        return path;

        void Dfs(string current)
        {
            var destinations = destinationsByNode.GetValueOrDefault(current);
            while (destinations?.Count>0) {
                var d = destinations.Dequeue();
                Dfs(d);
            }
            path.Insert(0, current);
        }
    }
}
