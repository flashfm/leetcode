// Copyright (c) 2020 Alexey Filatov
// 101 - Symmetric Tree (https://leetcode.com/problems/symmetric-tree)
// Date solved: 3/15/2020 10:27:56 PM +00:00
// Memory: 25.3 MB
// Runtime: 92 ms


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
    public bool IsSymmetric(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(root);
        while(queue.Count>0) {
            var a = queue.Dequeue();
            var b = queue.Dequeue();
            if (a==null && b==null) continue;
            if (a==null || b==null) return false;
            if (a.val != b.val) return false;
            queue.Enqueue(a.left);
            queue.Enqueue(b.right);
            queue.Enqueue(a.right);
            queue.Enqueue(b.left);
        }
        return true;
    }
}
