// Copyright (c) 2019 Alexey Filatov
// 94 - Binary Tree Inorder Traversal (https://leetcode.com/problems/binary-tree-inorder-traversal)
// Date solved: 12/22/2019 7:21:47 AM +00:00
// Memory: 29.1 MB
// Runtime: 248 ms


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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root==null) {
            return new int[0];
        }
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var visited = new HashSet<TreeNode>();
        stack.Push(root);
        while(stack.Count>0) {
            var n = stack.Pop();
            if (!visited.Contains(n)) {
                visited.Add(n);
                AddNode(stack, n);
            }
            else {
                result.Add(n.val);
            }
        }
        return result;
    }
    private void AddNode(Stack<TreeNode> stack, TreeNode n)
    {
        if (n.right!=null) stack.Push(n.right);
        stack.Push(n);
        if (n.left!=null) stack.Push(n.left);
    }
}
