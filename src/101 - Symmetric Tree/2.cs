// Copyright (c) 2020 Alexey Filatov
// 101 - Symmetric Tree (https://leetcode.com/problems/symmetric-tree)
// Date solved: 3/15/2020 10:23:33 PM +00:00
// Memory: 25.1 MB
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
    public bool IsSymmetric(TreeNode root) {
        return IsMirror(root, root);
    }
    
    private bool IsMirror(TreeNode a, TreeNode b)
    {
        if (a==null && b==null) return true;
        if (a==null || b==null) return false;
        return (a.val==b.val) && IsMirror(a.left, b.right) && IsMirror(a.right, b.left);
    }
}
