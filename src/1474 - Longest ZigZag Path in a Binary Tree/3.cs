// Copyright (c) 2024 Alexey Filatov
// 1474 - Longest ZigZag Path in a Binary Tree (https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree)
// Date solved: 10/28/2024 2:03:14 AM +00:00
// Memory: 58.7 MB
// Runtime: 6 ms


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
    private int result = 0;

    public int LongestZigZag(TreeNode root) {
        Visit(root, false, 0);
        return result;
    }

    private void Visit(TreeNode node, bool goLeft, int curPathLen)
    {
        if (node==null) {
            return;
        }
        result = Math.Max(result, curPathLen);
        Visit(node.left, false, goLeft ? curPathLen+1 : 1);
        Visit(node.right, true, !goLeft ? curPathLen+1 : 1);
    }
}
