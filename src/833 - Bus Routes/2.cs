// Copyright (c) 2024 Alexey Filatov
// 833 - Bus Routes (https://leetcode.com/problems/bus-routes)
// Date solved: 11/1/2024 10:46:44 PM +00:00
// Memory: 81 MB
// Runtime: 42 ms


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
        var queue = new Queue<(int, int)>();
        queue.Enqueue((source, 0));
        visited.Add(source);
        while(queue.Count>0) {
            var (n, buses) = queue.Dequeue();
            if (dict.TryGetValue(n, out var stopRoutes)) {
                foreach(var r in stopRoutes) {
                    if (routes[r]!=null) {
                        foreach(var a in routes[r]) {
                            if (a==target) {
                                return buses+1;
                            }
                            if (!visited.Contains(a)) {
                                visited.Add(a);
                                queue.Enqueue((a, buses+1));
                            }
                        }
                        routes[r] = null;
                    }
                }
            }
        }
        return -1;
    }
}
