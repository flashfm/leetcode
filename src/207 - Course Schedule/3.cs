// Copyright (c) 2022 Alexey Filatov
// 207 - Course Schedule (https://leetcode.com/problems/course-schedule)
// Date solved: 11/4/2022 5:07:15 AM +00:00
// Memory: 44.3 MB
// Runtime: 102 ms


public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjacentNodes = new List<int>[numCourses];
        for(var i=0; i<numCourses; i++) {
            adjacentNodes[i] = new List<int>();
        }
        foreach(var pair in prerequisites) {
            adjacentNodes[pair[0]].Add(pair[1]);
        }
        var visited = new bool[numCourses];
        var isInPath = new bool[numCourses];
        for(var i = 0; i<numCourses; i++) {
            if (Dfs(adjacentNodes, visited, isInPath, i)) {
                return false;
            }
        }
        return true;
    }
    private bool Dfs(List<int>[] adjacentNodes, bool[] visited, bool[] isInPath, int i)
    {
        if (isInPath[i]) {
            return true;
        }
        if (visited[i]) {
            return false;
        }
        visited[i] = isInPath[i] = true;
        foreach(var n in adjacentNodes[i]) {
            if (Dfs(adjacentNodes, visited, isInPath, n)) {
                return true;
            }
        }
        isInPath[i] = false;
        return false;
    }
}
