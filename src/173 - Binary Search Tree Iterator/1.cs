// Copyright (c) 2024 Alexey Filatov
// 173 - Binary Search Tree Iterator (https://leetcode.com/problems/binary-search-tree-iterator)
// Date solved: 10/2/2024 10:32:21 PM +00:00
// Memory: 62.8 MB
// Runtime: 149 ms


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
public class BSTIterator {

    private Stack<TreeNode> stack = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        Fill(root);
    }

    private void Fill(TreeNode node)
    {
        while(node!=null) {
            stack.Push(node);
            node = node.left;
        }
    }
    
    public int Next() {
        var node = stack.Pop();
        Fill(node.right);
        return node.val;
    }
    
    public bool HasNext() {
        return stack.Count>0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
