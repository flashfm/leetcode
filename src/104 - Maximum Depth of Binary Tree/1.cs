// Copyright (c) 2020 Alexey Filatov
// 104 - Maximum Depth of Binary Tree (https://leetcode.com/problems/maximum-depth-of-binary-tree)
// Date solved: 3/8/2020 4:57:17 AM +00:00
// Memory: 25.5 MB
// Runtime: 116 ms


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root==null) return 0;
        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;
    }    
}
