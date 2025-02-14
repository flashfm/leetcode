// Copyright (c) 2020 Alexey Filatov
// 98 - Validate Binary Search Tree (https://leetcode.com/problems/validate-binary-search-tree)
// Date solved: 3/14/2020 3:50:02 AM +00:00
// Memory: 26.1 MB
// Runtime: 104 ms


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
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MaxValue, long.MinValue);
    }
    
    private bool IsValidBST(TreeNode root, long lower, long upper)
    {
        if (root==null) return true;
        
        if (root.val>=lower || root.val<=upper) return false;
        
        if (!IsValidBST(root.left, root.val, upper)) return false;
        
        if (!IsValidBST(root.right, lower, root.val)) return false;
        
        return true;
    }
}
