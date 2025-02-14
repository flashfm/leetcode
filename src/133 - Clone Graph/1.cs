// Copyright (c) 2020 Alexey Filatov
// 133 - Clone Graph (https://leetcode.com/problems/clone-graph)
// Date solved: 10/21/2020 1:26:21 AM +00:00
// Memory: 31.8 MB
// Runtime: 248 ms


/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;
    
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
    
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
    
    public Node CloneGraph(Node node) {
        if (node==null) {
            return null;
        }
        return Clone(node);
    }
    
    private Node Clone(Node node)
    {
        var clone = new Node(node.val);
        visited[node] = clone;
        foreach(var c in node.neighbors) {
            if (!visited.ContainsKey(c))
                clone.neighbors.Add(Clone(c));
            else
                clone.neighbors.Add(visited[c]);
        }
        return clone;
    }
}
