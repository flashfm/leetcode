// Copyright (c) 2020 Alexey Filatov
// 103 - Binary Tree Zigzag Level Order Traversal (https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal)
// Date solved: 7/22/2020 7:50:54 AM +00:00
// Memory: 30.5 MB
// Runtime: 240 ms


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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {

        var result = new List<IList<int>>();
        if (root==null) return result;
        
        var level = new List<TreeNode>();
        level.Add(root);
        var back = false;
        
        while(level.Count>0) {
            
            var r = level.Select(n => n.val).ToList();
            if (back) {
                r.Reverse();
            }
            result.Add(r);
            back = !back;
            
            var newLevel = new List<TreeNode>();
            foreach(var n in level) {
                if (n.left!=null) newLevel.Add(n.left);
                if (n.right!=null) newLevel.Add(n.right);
            }
            
            level = newLevel;
        }
        
        return result;
    }    
}
