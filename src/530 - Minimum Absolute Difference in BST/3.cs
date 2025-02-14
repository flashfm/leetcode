// Copyright (c) 2024 Alexey Filatov
// 530 - Minimum Absolute Difference in BST (https://leetcode.com/problems/minimum-absolute-difference-in-bst)
// Date solved: 10/3/2024 4:36:03 AM +00:00
// Memory: 44.9 MB
// Runtime: 66 ms


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
    private int result = int.MaxValue;
    private TreeNode prev;

    public int GetMinimumDifference(TreeNode root) {
        Visit(root);
        return result;
    }

    private void Visit(TreeNode node)
    {
        if (node==null) {
            return;
        }

        Visit(node.left);

        if (prev!=null) {
            result = Math.Min(result, node.val - prev.val);
        }
        prev = node;

        Visit(node.right);
    }
}
