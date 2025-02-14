// Copyright (c) 2024 Alexey Filatov
// 106 - Construct Binary Tree from Inorder and Postorder Traversal (https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal)
// Date solved: 10/1/2024 3:55:10 AM +00:00
// Memory: 43.5 MB
// Runtime: 70 ms


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
    private Dictionary<int, int> indexByVal = new Dictionary<int, int>();
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        for(var i = 0; i<inorder.Length; i++) {
            indexByVal[inorder[i]] = i;
        }
        return BuildTree(inorder, 0, inorder.Length, postorder, 0);
    }

    public TreeNode BuildTree(int[] inorder, int istart, int size, int[] postorder, int pstart) {
        if (size==0) {
            return null;
        }
        var root = postorder[pstart + size - 1];
        if (size==1) {
            return new TreeNode(root);
        }
        var len = indexByVal[root] - istart;
        var left = BuildTree(inorder, istart, len, postorder, pstart);
        var right = BuildTree(inorder, istart + len + 1, size - len - 1, postorder, pstart + len);
        return new TreeNode(root, left, right);
    }
}
