// Copyright (c) 2020 Alexey Filatov
// 103 - Binary Tree Zigzag Level Order Traversal (https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal)
// Date solved: 1/7/2020 7:32:23 AM +00:00
// Memory: 30.7 MB
// Runtime: 240 ms


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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if (root==null) return result;
        var level = new List<TreeNode>();
        level.Add(root);
        var rightFirst = false;
        while(level.Count>0) {
            var values = level.Select(n=>n.val).ToList();
            if (!rightFirst) {
                values.Reverse();
            }
            result.Add(values);
                
            var nextLevel = new List<TreeNode>();
            foreach(var node in level) {
                if (node.right!=null) nextLevel.Add(node.right);
                if (node.left!=null) nextLevel.Add(node.left);
            }
            rightFirst = !rightFirst;
            level = nextLevel;
        }
        return result;
    }
}
