// Copyright (c) 2020 Alexey Filatov
// 116 - Populating Next Right Pointers in Each Node (https://leetcode.com/problems/populating-next-right-pointers-in-each-node)
// Date solved: 11/13/2020 9:56:22 AM +00:00
// Memory: 29.8 MB
// Runtime: 104 ms


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
        if (root==null) return null;
        var node = root;
        while(node.left!=null) {
            var c = node;
            while(c!=null) {
                c.left.next = c.right;
                var oldright = c.right;
                c = c.next;
                oldright.next = c?.left;
            }
            node = node.left;
        }
        return root;
    }
}
