// Copyright (c) 2024 Alexey Filatov
// 71 - Simplify Path (https://leetcode.com/problems/simplify-path)
// Date solved: 9/25/2024 10:46:00 PM +00:00
// Memory: 41.5 MB
// Runtime: 62 ms


public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
        foreach(var dir in path.Split('/', StringSplitOptions.RemoveEmptyEntries)) {
            if (dir==".") {
            }
            else if (dir=="..") {
                if (stack.Count>0) {
                    stack.Pop();
                }
            }
            else {
                stack.Push(dir);
            }
        }
        return "/" + string.Join('/', stack.Reverse());
    }
}
