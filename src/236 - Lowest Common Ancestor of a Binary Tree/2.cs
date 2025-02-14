// Copyright (c) 2022 Alexey Filatov
// 236 - Lowest Common Ancestor of a Binary Tree (https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree)
// Date solved: 10/17/2022 4:52:53 AM +00:00
// Memory: 41.5 MB
// Runtime: 176 ms


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
        var path1 = new List<TreeNode> { root };
        Find(root, p, path1);
        var path2 = new List<TreeNode> { root };
        Find(root, q, path2);
        var i = 0;
        while((i<path1.Count ? path1[i].val : null)==(i<path2.Count ? path2[i].val : null)) i++;
        return path1[i-1];
    }
    private bool Find(TreeNode node, TreeNode toFind, List<TreeNode> path)
    {
        if (node==toFind) return true;
        if (node.left!=null) {
            path.Add(node.left);
            if (Find(node.left, toFind, path)) {
                return true;
            }
            path.RemoveAt(path.Count-1);
        }
        if (node.right!=null) {
            path.Add(node.right);
            if (Find(node.right, toFind, path)) {
                return true;
            }
            path.RemoveAt(path.Count-1);
        }
        return false;
    }
}
