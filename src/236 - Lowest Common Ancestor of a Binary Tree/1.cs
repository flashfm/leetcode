// Copyright (c) 2022 Alexey Filatov
// 236 - Lowest Common Ancestor of a Binary Tree (https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree)
// Date solved: 10/17/2022 4:39:05 AM +00:00
// Memory: 42.4 MB
// Runtime: 185 ms


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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var parentByNode = new Dictionary<TreeNode, TreeNode>();
        BuildParents(parentByNode, root, null);
        var h1 = GetHeight(parentByNode, p);
        var h2 = GetHeight(parentByNode, q);
        for(var i = 0; i<Math.Abs(h1-h2); i++) {
            if (h1>h2) {
                parentByNode.TryGetValue(p, out p);
            }            
            else {
                parentByNode.TryGetValue(q, out q);
            }
        }
        while(p!=q) {
            parentByNode.TryGetValue(p, out p);
            parentByNode.TryGetValue(q, out q);
        }
        return p;
    }

    private void BuildParents(Dictionary<TreeNode, TreeNode> parentByNode, TreeNode node, TreeNode parent)
    {
        if (node==null) return;
        parentByNode[node] = parent;
        BuildParents(parentByNode, node.left, node);
        BuildParents(parentByNode, node.right, node);
    }

    private int GetHeight(Dictionary<TreeNode, TreeNode> parentByNode, TreeNode n)
    {
        int result = 0;
        while(n!=null) {
            result++;
            parentByNode.TryGetValue(n, out n);
        }
        return result;
    }
}
