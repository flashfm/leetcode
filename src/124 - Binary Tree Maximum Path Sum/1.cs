// Copyright (c) 2024 Alexey Filatov
// 124 - Binary Tree Maximum Path Sum (https://leetcode.com/problems/binary-tree-maximum-path-sum)
// Date solved: 10/2/2024 8:28:48 PM +00:00
// Memory: 48.1 MB
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
        var max = Math.Max(root.val, Math.Max(root.val + leftMax, root.val + rightMax));
        //Console.WriteLine("node="+root.val+", left="+leftMax + ", right=" + rightMax + ", max="+max);
        result = Math.Max(result, Math.Max(max, root.val + leftMax + rightMax));
        return max;
    }
}
