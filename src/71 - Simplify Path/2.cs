// Copyright (c) 2024 Alexey Filatov
// 71 - Simplify Path (https://leetcode.com/problems/simplify-path)
// Date solved: 9/25/2024 10:47:25 PM +00:00
// Memory: 41.1 MB
// Runtime: 56 ms


public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
        foreach(var dir in path.Split('/', StringSplitOptions.RemoveEmptyEntries)) {
            if (dir=="..") {
                if (stack.Count>0) {
                    stack.Pop();
                }
            }
            else if (dir!=".") {
                stack.Push(dir);
            }
        }
        return "/" + string.Join('/', stack.Reverse());
    }
}
