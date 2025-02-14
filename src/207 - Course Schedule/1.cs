// Copyright (c) 2022 Alexey Filatov
// 207 - Course Schedule (https://leetcode.com/problems/course-schedule)
// Date solved: 10/19/2022 3:56:20 AM +00:00
// Memory: 45.2 MB
// Runtime: 123 ms


public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjacentNodes = new List<int>[2000];
        foreach(var pair in prerequisites) {
            (adjacentNodes[pair[0]] ??= new List<int>()).Add(pair[1]);
        }
        var visited = new bool[adjacentNodes.Length];
        var isInPath = new bool[adjacentNodes.Length];
        for(var i = 0; i<visited.Length; i++) {
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
        if (adjacent != null) {
            foreach(var n in adjacent) {
                if (HasCycle(adjacentNodes, visited, isInPath, n)) {
                    return true;
                }
            }
        }
        isInPath[startIndex] = false;
        return false;
    }
}
