// Copyright (c) 2024 Alexey Filatov
// 530 - Minimum Absolute Difference in BST (https://leetcode.com/problems/minimum-absolute-difference-in-bst)
// Date solved: 10/3/2024 4:30:42 AM +00:00
// Memory: 44.9 MB
// Runtime: 79 ms


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

    public int GetMinimumDifference(TreeNode root) {
        Visit(root);
        return result;
    }

    private (int, int) Visit(TreeNode node)
    {
        // left <= node < right
        var l = node.val;
        var r = node.val;
        if (node.left!=null) {
            var (l1, max) = Visit(node.left);
            l = l1;
            result = Math.Min(result, Math.Abs(max-node.val));
        }
        if (node.right!=null) {
            var (min, r1) = Visit(node.right);
            r = r1;
            result = Math.Min(result, Math.Abs(min-node.val));
        }
        return (l, r);
    }
}
