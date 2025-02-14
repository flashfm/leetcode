// Copyright (c) 2020 Alexey Filatov
// 543 - Diameter of Binary Tree (https://leetcode.com/problems/diameter-of-binary-tree)
// Date solved: 4/12/2020 4:05:03 AM +00:00
// Memory: 25.7 MB
// Runtime: 140 ms


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
    
    private int maxLen = 1;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        Depth(root);
        return maxLen-1;
    }
    
    private int Depth(TreeNode node)
    {
        if (node==null) return 0;
        
        var l = Depth(node.left);
        var r = Depth(node.right);
        
        maxLen = Math.Max(maxLen, l+r+1);
        
        return Math.Max(l,r)+1;
    }
}
