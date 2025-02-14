// Copyright (c) 2020 Alexey Filatov
// 437 - Path Sum III (https://leetcode.com/problems/path-sum-iii)
// Date solved: 8/11/2020 6:00:46 AM +00:00
// Memory: 25.8 MB
// Runtime: 104 ms


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
    public int PathSum(TreeNode root, int sum) {   
        if (root==null) {
            return 0;
        }
        return GetCount(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
    }
    private int GetCount(TreeNode node, int remainder)
    {
        if (node==null) {
            return 0;
        }
        return (node.val == remainder ? 1 : 0)
            + GetCount(node.left, remainder - node.val)
            + GetCount(node.right, remainder - node.val);
    }
}
