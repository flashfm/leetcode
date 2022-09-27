// Invert Binary Tree
// https://leetcode.com/problems/invert-binary-tree
// Date solved: 05/29/2020 17:36:01 +00:00

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        InOrder(root);
        return root;
    }
    
    private void InOrder(TreeNode node)
    {
        if (node==null) return;
        
        InOrder(node.left);
        
        var t = node.left;
        node.left = node.right;
        node.right = t;
        
        InOrder(node.left);
    }
}
