// Copyright (c) 2024 Alexey Filatov
// 114 - Flatten Binary Tree to Linked List (https://leetcode.com/problems/flatten-binary-tree-to-linked-list)
// Date solved: 10/2/2024 4:57:09 AM +00:00
// Memory: 41.6 MB
// Runtime: 58 ms


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
    private TreeNode current = new TreeNode();

    public void Flatten(TreeNode root) {
        if (root!=null) {
            Visit(root);
        }
    }

    private void Visit(TreeNode node)
    {
        var right = node.right;
        var left = node.left;

        current = current.right = node;
        current.left = null;

        if (left!=null) {
            Visit(left);
        }
        if (right!=null) {
            Visit(right);
        }
    }
}
