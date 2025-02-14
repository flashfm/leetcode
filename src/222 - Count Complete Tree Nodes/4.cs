// Copyright (c) 2024 Alexey Filatov
// 222 - Count Complete Tree Nodes (https://leetcode.com/problems/count-complete-tree-nodes)
// Date solved: 10/3/2024 3:19:46 AM +00:00
// Memory: 49.4 MB
// Runtime: 90 ms


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
        var depth = GetDepth(root);
        //Console.WriteLine(depth);
        var node = root;
        var result = 0;
        while(node!=null) {
            var rightDepth = GetDepth(node.right);
            if (rightDepth==depth-1) {
                result += 1 << depth;
                node = node.right;
            }
            else {
                result += 1 << (depth-1);
                node = node.left;
            }
            depth--;
        }

        return result;
    }

    private int GetDepth(TreeNode root)
    {
        var depth = -1;
        var node = root;
        while(node!=null) {
            depth++;
            node = node.left;
        }
        return depth;
    }
}
