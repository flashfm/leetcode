// Copyright (c) 2024 Alexey Filatov
// 102 - Binary Tree Level Order Traversal (https://leetcode.com/problems/binary-tree-level-order-traversal)
// Date solved: 11/5/2024 6:05:06 AM +00:00
// Memory: 47.4 MB
// Runtime: 0 ms


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
    List<IList<int>> result = new();
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Visit(root, 0);
        return result;
    }
    private void Visit(TreeNode node, int level)
    {
        if (node==null) {
            return;
        }
        List<int> list;
        if (level<result.Count) {
            list = (List<int>)result[level];
        }
        else {
            list = new List<int>();
            result.Add(list);
        }
        list.Add(node.val);
        Visit(node.left, level+1);
        Visit(node.right, level+1);
    }
}
