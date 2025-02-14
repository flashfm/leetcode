// Copyright (c) 2022 Alexey Filatov
// 210 - Course Schedule II (https://leetcode.com/problems/course-schedule-ii)
// Date solved: 11/4/2022 5:06:03 AM +00:00
// Memory: 47.2 MB
// Runtime: 149 ms


public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var stack = new Stack<int>();
        var visited = new bool[numCourses];
        var isInPath = new bool[numCourses];
        var adjacentByNode = new List<int>[numCourses];
        for(var i = 0; i<numCourses; i++) {
            adjacentByNode[i] = new List<int>();
        }
        foreach(var pair in prerequisites) {
            adjacentByNode[pair[1]].Add(pair[0]);
        }
        for(var i=0; i<numCourses; i++) {
            if (Dfs(adjacentByNode, visited, isInPath, stack, i)) {
                return Array.Empty<int>();
            }
        }
        return stack.ToArray();
    }
    private bool Dfs(List<int>[] adjacentByNode, bool[] visited, bool[] isInPath, Stack<int> stack, int i)
    {
        if (isInPath[i]) {
            return true;
        }
        if (visited[i]) {
            return false;
        }
        isInPath[i] = visited[i] = true;
        foreach(var next in adjacentByNode[i]) {
            if (Dfs(adjacentByNode, visited, isInPath, stack, next)) {
                return true;
            }
        }
        stack.Push(i);
        isInPath[i] = false;
        return false;
    }
}
