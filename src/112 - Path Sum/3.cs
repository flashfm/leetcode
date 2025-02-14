// Copyright (c) 2024 Alexey Filatov
// 112 - Path Sum (https://leetcode.com/problems/path-sum)
// Date solved: 10/2/2024 7:04:46 PM +00:00
// Memory: 45.1 MB
// Runtime: 71 ms


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
    private bool result;
    private int targetSum;

    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root==null) {
            return false;
        }
        if (root.left == null && root.right == null && targetSum == root.val) {
            return true;
        }

        var remainder = targetSum - root.val;
        return HasPathSum(root.left, remainder) || HasPathSum(root.right, remainder);
    }
}
