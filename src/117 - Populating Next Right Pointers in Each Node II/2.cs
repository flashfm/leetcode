// Copyright (c) 2024 Alexey Filatov
// 117 - Populating Next Right Pointers in Each Node II (https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii)
// Date solved: 10/1/2024 4:17:45 AM +00:00
// Memory: 44.6 MB
// Runtime: 82 ms


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
        var orig = root;
        while(root!=null) {
            var tempRoot = new Node(0);
            var current = tempRoot;
            while(root!=null) {
                if (root.left!=null) {
                    current.next = root.left;
                    current = current.next;
                }
                if (root.right!=null) {
                    current.next = root.right;
                    current = current.next;
                }
                root = root.next;
            }
            root = tempRoot.next;
        }
        return orig;
    }
}
