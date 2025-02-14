// Copyright (c) 2024 Alexey Filatov
// 1116 - Maximum Level Sum of a Binary Tree (https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree)
// Date solved: 11/15/2024 3:51:45 AM +00:00
// Memory: 51.3 MB
// Runtime: 4 ms


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
    public int MaxLevelSum(TreeNode root) {
        var level = new List<TreeNode>();
        var newLevel = new List<TreeNode>();
        level.Add(root);
        var i = 1;
        var maxSum = int.MinValue;
        var result = 1;
        while(level.Count>0) {
            var sum = 0;
            foreach(var n in level) {
                sum += n.val;
                if (n.left!=null) {
                    newLevel.Add(n.left);
                }
                if (n.right!=null) {
                    newLevel.Add(n.right);
                }
            }
            if (sum>maxSum) {
                maxSum = sum;
                result = i;
            }
            i++;
            (level, newLevel) = (newLevel, level);
            newLevel.Clear();
        }
        return result;
    }
}
