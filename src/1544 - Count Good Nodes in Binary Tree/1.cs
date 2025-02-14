// Copyright (c) 2024 Alexey Filatov
// 1544 - Count Good Nodes in Binary Tree (https://leetcode.com/problems/count-good-nodes-in-binary-tree)
// Date solved: 11/15/2024 3:45:21 AM +00:00
// Memory: 64.2 MB
// Runtime: 200 ms


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
    int result;
    public int GoodNodes(TreeNode root) {
        Visit(root, int.MinValue);
        return result;
    }

    private void Visit(TreeNode node, int max)
    {
        if (node==null) {
            return;
        }
        if (max<=node.val) {
            result++;
        }
        max = Math.Max(max, node.val);
        Visit(node.left, max);
        Visit(node.right, max);
    }
}
