// Copyright (c) 2024 Alexey Filatov
// 222 - Count Complete Tree Nodes (https://leetcode.com/problems/count-complete-tree-nodes)
// Date solved: 10/3/2024 2:15:19 AM +00:00
// Memory: 49 MB
// Runtime: 87 ms


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
    private int depth = -1;
    private bool stop;
    private int result;

    public int CountNodes(TreeNode root) {
        if (root==null) {
            return 0;
        }
        var node = root;
        while(node!=null) {
            depth++;
            result += 1 << depth;
            node = node.left;
        }
        Visit(root, 0);
        return result;
    }

    private void Visit(TreeNode node, int d)
    {
        if (stop) {
            return;
        }
        if (d==depth) {
            if (node==null) {
                result--;
                return;
            }
            else {
                stop = true;
                return;
            }
        }
        Visit(node.right, d+1);
        Visit(node.left, d+1);
    }
}
