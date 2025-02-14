// Copyright (c) 2024 Alexey Filatov
// 450 - Delete Node in a BST (https://leetcode.com/problems/delete-node-in-a-bst)
// Date solved: 11/15/2024 5:22:47 AM +00:00
// Memory: 50.4 MB
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
    public TreeNode DeleteNode(TreeNode root, int key) {
        // search
        var fakeRoot = new TreeNode(0, root);
        var node = root;
        var parent = fakeRoot;
        while(node!=null) {
            if (key==node.val) {
                break;
            }
            parent = node;
            node = key<node.val ? node.left : node.right;
        }
        if (node==null) {
            return root;
        }
        // replace deleted with right node
        var newNode = node.right ?? node.left;
        var leftNode = node.right!=null ? node.left : null;
        if (parent.left==node) {
            parent.left = newNode;
        }
        else {
            parent.right = newNode;
        }
        if (leftNode==null) {
            return fakeRoot.left;
        }
        // embed left node
        node = newNode;
        TreeNode p = null;
        while(node!=null) {
            p = node;
            if (node.val<leftNode.val) {
                node = node.right;
            }
            else {
                node = node.left;
            }
        }
        if (p!=null) {
            if (p.val<leftNode.val) {
                p.right = leftNode;
            }
            else {
                p.left = leftNode;
            }
        }
        return fakeRoot.left;
    }
}
