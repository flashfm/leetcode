// Copyright (c) 2024 Alexey Filatov
// 124 - Binary Tree Maximum Path Sum (https://leetcode.com/problems/binary-tree-maximum-path-sum)
// Date solved: 11/5/2024 4:58:40 AM +00:00
// Memory: 48.2 MB
// Runtime: 0 ms


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
    private int result = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Visit(root);
        return result;
    }
    private int Visit(TreeNode root)
    {
        if (root==null) {
            return 0;
        }
        var leftMax = Visit(root.left);
        var rightMax = Visit(root.right);
        var max = Max(root.val, root.val + leftMax, root.val + rightMax);
        result = Max(result, max, root.val + leftMax + rightMax);
        return max;
    }

    private static int Max(int a, int b, int c)
        => Math.Max(a, Math.Max(b, c));
}
