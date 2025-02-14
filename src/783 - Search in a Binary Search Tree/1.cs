// Copyright (c) 2024 Alexey Filatov
// 783 - Search in a Binary Search Tree (https://leetcode.com/problems/search-in-a-binary-search-tree)
// Date solved: 11/15/2024 3:54:19 AM +00:00
// Memory: 50.2 MB
// Runtime: 0 ms


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
    public TreeNode SearchBST(TreeNode root, int val) {
        var node = root;
        while(node!=null) {
            if (node.val==val) {
                return node;
            }
            else if (val<node.val) {
                node = node.left;
            }
            else {
                node = node.right;
            }
        }
        return null;
    }
}
