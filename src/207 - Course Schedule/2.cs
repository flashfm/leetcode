// Copyright (c) 2022 Alexey Filatov
// 207 - Course Schedule (https://leetcode.com/problems/course-schedule)
// Date solved: 11/4/2022 5:00:51 AM +00:00
// Memory: 44.1 MB
// Runtime: 129 ms


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
            if (HasCycle(adjacentNodes, visited, isInPath, i)) {
                return false;
            }
        }
        return true;
    }
    private bool HasCycle(List<int>[] adjacentNodes, bool[] visited, bool[] isInPath, int startIndex)
    {
        // run DFS

        if (isInPath[startIndex]) {
            return true;
        }
        if (visited[startIndex]) {
            return false;
        }

        visited[startIndex] = isInPath[startIndex] = true;
        
        var adjacent = adjacentNodes[startIndex];
        foreach(var n in adjacent) {
            if (HasCycle(adjacentNodes, visited, isInPath, n)) {
                return true;
            }
        }
        isInPath[startIndex] = false;
        return false;
    }
}
