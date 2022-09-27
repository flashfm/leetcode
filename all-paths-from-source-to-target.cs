// All Paths From Source to Target
// https://leetcode.com/problems/all-paths-from-source-to-target
// Date solved: 07/25/2020 05:18:44 +00:00

public class Node
{
    public int NodeIndex;
    public int NextIndex;
}

public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        if (graph==null || graph.Length==0) return result;
        
        var lastIndex = graph.Length-1;

        var stack = new Stack<Node>();
        stack.Push(new Node { NodeIndex = 0, NextIndex = 0 });

        while(stack.Count>0) {
            var node = stack.Peek();
            var connections = graph[node.NodeIndex];
            // try forward
            if (node.NextIndex<connections.Length) {
                var nextNode = connections[node.NextIndex];
                node.NextIndex++;
                stack.Push(new Node { NodeIndex = nextNode, NextIndex = 0 });
                if (nextNode==lastIndex) {
                    AddPath(result, stack);
                }
            }
            else {
                // backward
                stack.Pop();
            }
        }
        return result;
    }
    
    private void AddPath(IList<IList<int>> result, Stack<Node> stack)
    {
        var path = stack.Select(n => n.NodeIndex).ToList();
        path.Reverse();
        result.Add(path);
    }
}
