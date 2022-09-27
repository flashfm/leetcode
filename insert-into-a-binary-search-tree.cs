// Insert into a Binary Search Tree
// https://leetcode.com/problems/insert-into-a-binary-search-tree
// Date solved: 10/06/2020 16:23:45 +00:00

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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        return Insert(root, val);
    }
    private TreeNode Insert(TreeNode node, int val)
    {
        if (node==null) {
            var newNode = new TreeNode(val);
            return newNode;
        }
        if (val>node.val) {
            node.right = Insert(node.right, val);
        }
        else {
            node.left = Insert(node.left, val);
        }
        return node;
    }
}
