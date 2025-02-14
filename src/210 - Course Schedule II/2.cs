// Copyright (c) 2024 Alexey Filatov
// 210 - Course Schedule II (https://leetcode.com/problems/course-schedule-ii)
// Date solved: 11/5/2024 5:52:44 AM +00:00
// Memory: 50.9 MB
// Runtime: 3 ms


public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var listByNode = new List<int>[numCourses];
        var incomings = new int[numCourses];
        foreach(var pre in prerequisites) {
            var from = pre[1];
            var to = pre[0];
            (listByNode[from] ?? (listByNode[from] = new List<int>())).Add(to);
            incomings[to]++;
        }
        var result = new List<int>();
        var queue = new Queue<int>();
        for(var i = 0; i<numCourses; i++) {
            if (incomings[i]==0) {
                queue.Enqueue(i);
            }
        }
        while(queue.Count>0) {
            var n = queue.Dequeue();
            result.Add(n);
            var list = listByNode[n];
            if (list!=null) {
                foreach(var next in list) {
                    incomings[next]--;
                    if (incomings[next]==0) {
                        queue.Enqueue(next);
                    }
                }
            }
        }
        return result.Count==numCourses ? result.ToArray() : new int[0];
    }
}
