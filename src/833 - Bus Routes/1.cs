// Copyright (c) 2024 Alexey Filatov
// 833 - Bus Routes (https://leetcode.com/problems/bus-routes)
// Date solved: 11/1/2024 10:44:20 PM +00:00
// Memory: 79.5 MB
// Runtime: 39 ms


public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        if (source==target) {
            return 0;
        }
        var dict = new Dictionary<int, List<int>>();
        for(var r = 0; r<routes.Length; r++) {
            foreach(var s in routes[r]) {
                (dict.GetValueOrDefault(s) ?? (dict[s] = new List<int>())).Add(r);
            }
        }
        var visited = new HashSet<int>();
        var visitedRoutes = new HashSet<int>();
        var queue = new Queue<(int, int)>();
        queue.Enqueue((source, 0));
        visited.Add(source);
        while(queue.Count>0) {
            var (n, buses) = queue.Dequeue();
            var stopRoutes = dict.GetValueOrDefault(n);
            if (stopRoutes==null) {
                continue;
            }
            foreach(var r in stopRoutes) {
                if (visitedRoutes.Contains(r)) {
                    continue;
                }
                visitedRoutes.Add(r);
                foreach(var a in routes[r]) {
                    if (a==target) {
                        return buses+1;
                    }
                    if (!visited.Contains(a)) {
                        visited.Add(a);
                        queue.Enqueue((a, buses+1));
                    }
                }
            }
        }
        return -1;
    }
}
