// Copyright (c) 2024 Alexey Filatov
// 904 - Leaf-Similar Trees (https://leetcode.com/problems/leaf-similar-trees)
// Date solved: 11/15/2024 12:09:21 AM +00:00
// Memory: 42.9 MB
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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var vals = new Queue<int>();
        var result = true;
        Visit(root1);
        VisitCheck(root2);
        return result && vals.Count==0;
    
        void Visit(TreeNode node)
        {
            if (node==null) {
                return;
            }
            if (node.left==null && node.right==null) {
                vals.Enqueue(node.val);
            }
            Visit(node.left);
            Visit(node.right);
        }
        
        void VisitCheck(TreeNode node)
        {
            if (!result || node==null) {
                return;
            }
            if (node.left==null && node.right==null) {
                if (vals.Count==0) {
                    result = false;
                }
                else {
                    result = node.val == vals.Dequeue();
                }
            }
            VisitCheck(node.left);
            VisitCheck(node.right);
        }
    }
}
