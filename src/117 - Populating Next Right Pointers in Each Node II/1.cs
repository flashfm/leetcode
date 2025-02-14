// Copyright (c) 2024 Alexey Filatov
// 117 - Populating Next Right Pointers in Each Node II (https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii)
// Date solved: 10/1/2024 4:10:46 AM +00:00
// Memory: 45.1 MB
// Runtime: 76 ms


/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if (root==null) {
            return null;
        }
        var prevLayer = new List<Node>() {root};
        while(prevLayer.Count>0) {
            var layer = new List<Node>();
            foreach(var n in prevLayer) {
                if (n.left!=null) {
                    layer.Add(n.left);
                }
                if (n.right!=null) {
                    layer.Add(n.right);
                }
            }
            Node prev = null;
            foreach(var n in layer) {
                if (prev!=null) {
                    prev.next = n;
                }
                prev = n;
            }
            prevLayer = layer;
        }
        return root;
    }
}
