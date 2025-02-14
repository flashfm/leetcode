// Copyright (c) 2020 Alexey Filatov
// 98 - Validate Binary Search Tree (https://leetcode.com/problems/validate-binary-search-tree)
// Date solved: 3/14/2020 4:03:32 AM +00:00
// Memory: 26.2 MB
// Runtime: 88 ms


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
    public bool IsValidBST(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var prev = long.MinValue;
            
        while(stack.Count>0 || root!=null) {
            while(root!=null) {
                stack.Push(root);
                root = root.left;
            }
            
            root = stack.Pop();
            
            if (root.val<=prev) return false;

            prev = root.val;
            root = root.right;
        }

        return true;
    }
}
