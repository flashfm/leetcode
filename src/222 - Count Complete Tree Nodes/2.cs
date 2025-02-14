// Copyright (c) 2024 Alexey Filatov
// 222 - Count Complete Tree Nodes (https://leetcode.com/problems/count-complete-tree-nodes)
// Date solved: 10/3/2024 3:05:06 AM +00:00
// Memory: 49.1 MB
// Runtime: 96 ms


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

    public int CountNodes(TreeNode root) {
        if (root==null) {
            return 0;
        }
        var depth = -1;
        var node = root;
        var result = 0;
        while(node!=null) {
            if (node.left==null && node.right==null) {
                result++;
                break;
            }
            var leftDepth = GetDepth(node.left);
            if (depth==-1) {
                depth = leftDepth;
            }
            var rightDepth = GetDepth(node.right);
            if (leftDepth==rightDepth) {
                result += 1 << (leftDepth-1);
                node = node.right;
            }
            else {
                node = node.left;
            }
        }
        for(var i = 0; i<depth; i++) {
            result += 1 << i;
        }

        return result;
    }

    private int GetDepth(TreeNode root)
    {
        if (root==null) {
            return 0;
        }
        var depth = 0;
        var node = root;
        while(node!=null) {
            depth++;
            node = node.left;
        }
        return depth;
    }
}
