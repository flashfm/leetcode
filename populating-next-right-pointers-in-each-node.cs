// Populating Next Right Pointers in Each Node
// https://leetcode.com/problems/populating-next-right-pointers-in-each-node
// Date solved: 01/30/2020 05:57:08 +00:00

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
        
        Traverse(node.left);
        Traverse(node.right);
        
        if (node.left!=null) {
            node.left.next = node.right;
        
            var n = node.left.right;
            var m = node.right.left;
            while(n!=null && n.next==null) {
                n.next = m;
                n = n.right;
                m = m.left;
            }
        }
    }
}
