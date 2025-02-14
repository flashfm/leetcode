// Copyright (c) 2024 Alexey Filatov
// 637 - Average of Levels in Binary Tree (https://leetcode.com/problems/average-of-levels-in-binary-tree)
// Date solved: 10/3/2024 3:26:40 AM +00:00
// Memory: 50.1 MB
// Runtime: 112 ms


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
    public IList<double> AverageOfLevels(TreeNode root) {
        var result = new List<double>();
        var level = new List<TreeNode>() { root };
        while(level.Count>0) {
            var newLevel = new List<TreeNode>();
            double sum = 0;
            foreach(var node in level) {
                sum += node.val;
                if (node.left!=null) {
                    newLevel.Add(node.left);
                }
                if (node.right!=null) {
                    newLevel.Add(node.right);
                }
            }
            result.Add(sum / level.Count);
            level = newLevel;
        }
        return result;
    }
}
