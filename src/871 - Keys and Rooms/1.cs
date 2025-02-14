// Copyright (c) 2024 Alexey Filatov
// 871 - Keys and Rooms (https://leetcode.com/problems/keys-and-rooms)
// Date solved: 11/15/2024 7:44:01 PM +00:00
// Memory: 45.5 MB
// Runtime: 1 ms


public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var n = rooms.Count;
        var visited = new bool[n];
        var queue = new Queue<int>();
        queue.Enqueue(0);
        visited[0] = true;
        while(queue.Count>0) {
            var r = queue.Dequeue();
            var newRooms = rooms[r];
            foreach(var nr in newRooms) {
                if (!visited[nr]) {
                    visited[nr] = true;
                    queue.Enqueue(nr);
                }
            }
        }
        return visited.All(v => v);
    }
}
