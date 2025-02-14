// Copyright (c) 2019 Alexey Filatov
// 297 - Serialize and Deserialize Binary Tree (https://leetcode.com/problems/serialize-and-deserialize-binary-tree)
// Date solved: 12/28/2019 10:08:32 PM +00:00
// Memory: 31.6 MB
// Runtime: 132 ms


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        var sb = new StringBuilder();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0) {
            var n = queue.Dequeue();
            if (n==null) {
                sb.Append('n');    
            }
            else {
                sb.Append(n.val);
                queue.Enqueue(n.left);
                queue.Enqueue(n.right);
            }
            sb.Append(',');
        }
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        var isNull = false;
        var val = new StringBuilder();
        TreeNode root = null;
        var queue = new Queue<TreeNode>();
        var fillingRight = false;
        foreach(var c in data) {
            if (c==',') {
                TreeNode current = isNull ? null : new TreeNode(int.Parse(val.ToString()));
                if (current!=null) queue.Enqueue(current);              
                if (root==null) {
                    root = current;
                }
                else {
                    var parent = queue.Peek();
                    if (fillingRight) {
                        parent.right = current;
                        queue.Dequeue();
                        fillingRight = false;
                    }
                    else {
                        parent.left = current;
                        fillingRight = true;
                    }
                }               
                isNull = false;
                val.Clear();
            }
            else if (c=='n') {
                isNull = true;
            }
            else {
                val.Append(c);
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
