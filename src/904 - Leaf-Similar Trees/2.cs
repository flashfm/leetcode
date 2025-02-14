// Copyright (c) 2024 Alexey Filatov
// 904 - Leaf-Similar Trees (https://leetcode.com/problems/leaf-similar-trees)
// Date solved: 11/15/2024 12:35:55 AM +00:00
// Memory: 42.7 MB
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
        var s1 = new Stack<TreeNode>();
        s1.Push(root1);
        var s2 = new Stack<TreeNode>();
        s2.Push(root2);
        while(s1.Count>0 && s2.Count>0) {
            var l1 = GetNextLeaf(s1);
            var l2 = GetNextLeaf(s2);
            if (l1!=l2) {
                return false;
            }
        }
        return s1.Count==0 && s2.Count==0;

        int GetNextLeaf(Stack<TreeNode> s)
        {
            while(true) {
                var n = s.Pop();
                if (n.left!=null) {
                    s.Push(n.left);
                }
                if (n.right!=null) {
                    s.Push(n.right);
                }
                if (n.left==null && n.right==null) {
                    return n.val;
                }
            }
        }
    }
}
