// Copyright (c) 2024 Alexey Filatov
// 112 - Path Sum (https://leetcode.com/problems/path-sum)
// Date solved: 10/2/2024 7:00:44 PM +00:00
// Memory: 45.2 MB
// Runtime: 89 ms


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
        this.targetSum = targetSum;
        Visit(root, 0);
        return result;
    }

    private void Visit(TreeNode node, int sumSoFar)
    {
        if (result || node==null) {
            return;
        }
        var newSum = sumSoFar + node.val;
        if (node.left == null && node.right == null && newSum == targetSum) {
            result = true;
            return;
        }
        Visit(node.left, newSum);
        Visit(node.right, newSum);
    }
}
