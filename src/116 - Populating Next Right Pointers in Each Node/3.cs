// Copyright (c) 2020 Alexey Filatov
// 116 - Populating Next Right Pointers in Each Node (https://leetcode.com/problems/populating-next-right-pointers-in-each-node)
// Date solved: 1/30/2020 6:07:37 AM +00:00
// Memory: 29.7 MB
// Runtime: 224 ms


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
        Traverse(root);
        return root;
    }
    
    private void Traverse(Node node)
    {
        if (node==null) return;
        
        while(node.left!=null) {
            
            var c = node;
            while(c!=null) {
                c.left.next = c.right;
                if (c.next!=null)
                        c.right.next = c.next.left;
                
                c = c.next;
            }
            
            node = node.left;
        }
    }
}
