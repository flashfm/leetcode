// Copyright (c) 2019 Alexey Filatov
// 297 - Serialize and Deserialize Binary Tree (https://leetcode.com/problems/serialize-and-deserialize-binary-tree)
// Date solved: 12/28/2019 10:20:11 PM +00:00
// Memory: 32.7 MB
// Runtime: 128 ms


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
        serialize(root, sb);
        return sb.ToString();
    }
    
    private void serialize(TreeNode n, StringBuilder sb)
    {
        if (sb.Length>0) {
            sb.Append(",");
        }
        sb.Append(n==null ? "n" : n.val.ToString());
        if (n!=null) {
            serialize(n.left, sb);
            serialize(n.right, sb);
        }
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        var queue = new Queue<string>(data.Split(','));
        return deserialize(queue);
    }
    private TreeNode deserialize(Queue<string> queue)
    {
        var v = queue.Dequeue();
        if (v=="n") {
            return null;
        }
        else {
            var node = new TreeNode(int.Parse(v));
            node.left = deserialize(queue);
            node.right = deserialize(queue);
            return node;
        }
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
