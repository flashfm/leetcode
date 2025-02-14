// Copyright (c) 2020 Alexey Filatov
// 230 - Kth Smallest Element in a BST (https://leetcode.com/problems/kth-smallest-element-in-a-bst)
// Date solved: 2/3/2020 7:24:03 AM +00:00
// Memory: 28.1 MB
// Runtime: 108 ms


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
    public int KthSmallest(TreeNode root, int k) {
        return Inorder(root, ref k);
    }
    private int Inorder(TreeNode root, ref int k)
    {
        if (root==null) {
            return -1;
        }
        
        var l = Inorder(root.left, ref k);
        if (l!=-1) return l;
        
        // root
        k--;
        if (k==0) return root.val;
        
        var r = Inorder(root.right, ref k);
        if (r!=-1) return r;
        
        return -1;
    }
}
