// Copyright (c) 2020 Alexey Filatov
// 104 - Maximum Depth of Binary Tree (https://leetcode.com/problems/maximum-depth-of-binary-tree)
// Date solved: 3/8/2020 4:58:02 AM +00:00
// Memory: 25.4 MB
// Runtime: 96 ms


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
        return root==null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }    
}
