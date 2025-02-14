// Copyright (c) 2020 Alexey Filatov
// 100 - Same Tree (https://leetcode.com/problems/same-tree)
// Date solved: 7/14/2020 6:43:37 AM +00:00
// Memory: 24.1 MB
// Runtime: 172 ms


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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p==null && q==null) {
            return true;
        }
        if (p!=null && q!=null && p.val!=q.val) {
            return false;
        }
        if ((p!=null && q==null) || (p==null && q!=null)) {
            return false;
        }
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
