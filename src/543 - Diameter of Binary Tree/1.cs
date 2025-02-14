// Copyright (c) 2020 Alexey Filatov
// 543 - Diameter of Binary Tree (https://leetcode.com/problems/diameter-of-binary-tree)
// Date solved: 4/12/2020 3:58:30 AM +00:00
// Memory: 26.4 MB
// Runtime: 132 ms


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
    
    private int maxLen;
    private Dictionary<TreeNode, int> cache = new Dictionary<TreeNode, int>();
    
    public int DiameterOfBinaryTree(TreeNode root) {
        InOrder(root);
        return maxLen;
    }
    
    private void InOrder(TreeNode node)
    {
        if (node==null) return;
        InOrder(node.left);
        
        var len = 0;
        if (node.left!=null) len += GetMaxDepth(node.left) + 1;
        if (node.right!=null) len += GetMaxDepth(node.right) + 1;
        
        maxLen = Math.Max(maxLen, len);
        
        InOrder(node.right);
    }
    
    private int GetMaxDepth(TreeNode node)
    {
        if (node==null) return 0;
        if (node.left==null && node.right==null) return 0;
        
        if (cache.TryGetValue(node, out var depth)) {
            return depth;
        }
        
        depth = Math.Max(GetMaxDepth(node.left), GetMaxDepth(node.right)) + 1;
        
        cache[node] = depth;
        return depth;
    }
}
