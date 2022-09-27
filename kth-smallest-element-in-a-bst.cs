// Kth Smallest Element in a BST
// https://leetcode.com/problems/kth-smallest-element-in-a-bst
// Date solved: 02/03/2020 07:39:55 +00:00

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
    public int KthSmallest(TreeNode root, int k) {
        var stack = new Stack<TreeNode>();
        var n = root;
        while(true) {
            while(n!=null) {
                stack.Push(n);
                n = n.left;
            }
            n = stack.Pop();
                        
            if (--k==0) return n.val;
            
            n = n.right;
        }
        //return Inorder(root, ref k);
    }
    private int Inorder(TreeNode root, ref int k)
    {
        if (root==null) {
            return -1;
        }
        
        var l = Inorder(root.left, ref k);
        if (l!=-1) return l;
        
        // root
        
        var r = Inorder(root.right, ref k);
        if (r!=-1) return r;
        
        return -1;
    }
}
