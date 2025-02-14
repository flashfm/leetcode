// Copyright (c) 2020 Alexey Filatov
// 105 - Construct Binary Tree from Preorder and Inorder Traversal (https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal)
// Date solved: 1/27/2020 7:26:53 AM +00:00
// Memory: 27.1 MB
// Runtime: 88 ms


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
        var indexByVal = new Dictionary<int, int>();
        for(var i=0;i<inorder.Length;i++) indexByVal[inorder[i]] = i;
        
        return BuildTree(preorder, 0, preorder.Length-1, inorder, 0, inorder.Length-1,
                        indexByVal);
    }
    
    private TreeNode BuildTree(int[] preorder, int preorderLeft, int preorderRight,
        int[] inorder, int inorderLeft, int inorderRight, Dictionary<int, int> indexByVal)
    {    
        if (preorderLeft>preorderRight || preorderLeft==preorder.Length
           || inorderLeft==inorder.Length || inorderLeft>inorderRight) return null;
        
        var rootIndex = preorderLeft;
        var root = preorder[rootIndex];
    
        var node = new TreeNode(root);
        
        var inorderRootIndex = indexByVal[root];
        
        var leftSubtreeSize = inorderRootIndex - inorderLeft;
        
        var j = rootIndex + leftSubtreeSize;
        
        node.left = BuildTree(preorder, rootIndex+1, j, inorder, inorderLeft, inorderRootIndex - 1, indexByVal);
        node.right = BuildTree(preorder, j+1, preorderRight, inorder, inorderRootIndex+1,    inorderRight, indexByVal);
    
        return node;
    }
}
