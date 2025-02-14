// Copyright (c) 2020 Alexey Filatov
// 105 - Construct Binary Tree from Preorder and Inorder Traversal (https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal)
// Date solved: 1/27/2020 7:24:11 AM +00:00
// Memory: 26.6 MB
// Runtime: 240 ms


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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildTree(preorder, 0, preorder.Length-1, inorder, 0, inorder.Length-1);
    }
    
    private TreeNode BuildTree(int[] preorder, int preorderLeft, int preorderRight,
        int[] inorder, int inorderLeft, int inorderRight)
    {    
        if (preorderLeft>preorderRight || preorderLeft==preorder.Length
           || inorderLeft==inorder.Length || inorderLeft>inorderRight) return null;
        
        var rootIndex = preorderLeft;
        var root = preorder[rootIndex];
    
        var node = new TreeNode(root);
        
        var inorderRootIndex = Array.IndexOf(inorder, root, inorderLeft);
        
        var leftSubtreeSize = inorderRootIndex - inorderLeft;
        
        var j = rootIndex + leftSubtreeSize;
        
        node.left = BuildTree(preorder, rootIndex+1, j, inorder, inorderLeft, inorderRootIndex - 1);
        node.right = BuildTree(preorder, j+1, preorderRight, inorder, inorderRootIndex+1,    inorderRight);
    
        return node;
    }
}
