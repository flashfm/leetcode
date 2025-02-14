// Copyright (c) 2020 Alexey Filatov
// 100 - Same Tree (https://leetcode.com/problems/same-tree)
// Date solved: 7/14/2020 6:47:59 AM +00:00
// Memory: 24.4 MB
// Runtime: 132 ms


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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        queue.Enqueue(q);
        while(queue.Count>0) {
            var n1 = queue.Dequeue();
            var n2 = queue.Dequeue();
            if (n1==null && n2==null) continue;
            if (n1!=null && n2!=null && n1.val!=n2.val) {
                return false;
            }
            if ((n1!=null && n2==null) || (n1==null && n2!=null)) {
                return false;
            }
            queue.Enqueue(n1.left);
            queue.Enqueue(n2.left);
            queue.Enqueue(n1.right);
            queue.Enqueue(n2.right);
        }
        return true;
    }
}
