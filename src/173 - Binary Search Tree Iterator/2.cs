// Copyright (c) 2024 Alexey Filatov
// 173 - Binary Search Tree Iterator (https://leetcode.com/problems/binary-search-tree-iterator)
// Date solved: 10/2/2024 10:48:51 PM +00:00
// Memory: 62.1 MB
// Runtime: 151 ms


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

    private List<TreeNode> list = new List<TreeNode>();
    private int i = 0;

    public BSTIterator(TreeNode root) {
        Visit(root);
    }

    private void Visit(TreeNode node)
    {
        if (node==null) {
            return;
        }
        Visit(node.left);
        list.Add(node);
        Visit(node.right);
    }
    
    public int Next() {
        return list[i++].val;
    }
    
    public bool HasNext() {
        return i<list.Count;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
