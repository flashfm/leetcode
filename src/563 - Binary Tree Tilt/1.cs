// Copyright (c) 2020 Alexey Filatov
// 563 - Binary Tree Tilt (https://leetcode.com/problems/binary-tree-tilt)
// Date solved: 11/9/2020 4:37:01 AM +00:00
// Memory: 28.7 MB
// Runtime: 96 ms


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
    private int tilt;
    
    public int FindTilt(TreeNode root) {
        GetSum(root);
        return tilt;
    }
    
    private int GetSum(TreeNode node)
    {
        if (node==null) return 0;
        var l = GetSum(node.left);
        var r = GetSum(node.right);
        tilt += Math.Abs(l-r);
        return l+r+node.val;
    }
}
