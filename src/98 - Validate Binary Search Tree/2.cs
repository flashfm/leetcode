// Copyright (c) 2020 Alexey Filatov
// 98 - Validate Binary Search Tree (https://leetcode.com/problems/validate-binary-search-tree)
// Date solved: 3/14/2020 3:58:12 AM +00:00
// Memory: 26.2 MB
// Runtime: 100 ms


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
        var stack = new Stack<(TreeNode, int?, int?)>();
        stack.Push((root, null, null));
        
        while(stack.Count>0) {
            var (node, lower, upper) = stack.Pop();

            if (node==null) continue;    
            if (lower!=null && node.val>=lower) return false;
            if (upper!=null && node.val<=upper) return false;
            
            stack.Push((node.left, node.val, upper));
            stack.Push((node.right, lower, node.val));
        }

        return true;
    }
}
