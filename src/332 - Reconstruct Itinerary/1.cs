// Copyright (c) 2024 Alexey Filatov
// 332 - Reconstruct Itinerary (https://leetcode.com/problems/reconstruct-itinerary)
// Date solved: 10/21/2024 3:33:50 AM +00:00
// Memory: 62 MB
// Runtime: 22 ms


public class Solution {
    Dictionary<string, Dictionary<string, int>> destinationsByNode;
    string[] maxPath = null;
    List<string> path = [];
    int n;

    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        n = tickets.Count;
        destinationsByNode = new Dictionary<string, Dictionary<string, int>>();
        foreach(var t in tickets) {
            var from = t[0];
            var to = t[1];
            var dests = (destinationsByNode.GetValueOrDefault(from) ?? (destinationsByNode[from] = new Dictionary<string, int>()));
            dests[to] = dests.GetValueOrDefault(to) + 1;
        }

        Dfs("JFK");

        return maxPath;
    }

    private void Dfs(string current)
    {
        if (maxPath != null) {
            return;
        }
        path.Add(current);
        if (path.Count==n+1) {
            maxPath = path.ToArray();
        }

        var destinations = destinationsByNode.GetValueOrDefault(current);
        // always go in lexical order (because sorted), if path > max, remember it
        if (destinations?.Count()>0) {
            // go further
            var dests = destinations.Keys.ToArray();
            Array.Sort(dests);
            foreach(var d in dests) {
                if (destinations[d] == 0) {
                    continue;
                }
                destinations[d]--;
                Dfs(d);
                destinations[d]++;
            }
        }

        path.RemoveAt(path.Count-1);
    }
}
