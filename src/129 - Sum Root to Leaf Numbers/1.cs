// Copyright (c) 2024 Alexey Filatov
// 129 - Sum Root to Leaf Numbers (https://leetcode.com/problems/sum-root-to-leaf-numbers)
// Date solved: 10/2/2024 7:10:37 PM +00:00
// Memory: 40.5 MB
// Runtime: 54 ms


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
    private int result = 0;

    public int SumNumbers(TreeNode root) {
        Visit(root, 0);
        return result;
    }
    private void Visit(TreeNode node, int number)
    {
        if (node==null) {
            return;
        }
        var current = number*10 + node.val;
        if (node.left==null && node.right==null) {
            result += current;
        }
        if (node.left!=null) {
            Visit(node.left, current);
        }
        if (node.right!=null) {
            Visit(node.right, current);
        }
    }
}
