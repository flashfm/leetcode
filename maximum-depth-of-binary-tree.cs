// Maximum Depth of Binary Tree
// https://leetcode.com/problems/maximum-depth-of-binary-tree
// Date solved: 03/08/2020 04:58:02 +00:00

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
    public int MaxDepth(TreeNode root) {
        return root==null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }    
}
