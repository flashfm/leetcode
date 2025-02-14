// Copyright (c) 2025 Alexey Filatov
// 337 - House Robber III (https://leetcode.com/problems/house-robber-iii)
// Date solved: 1/7/2025 8:06:06 AM +00:00
// Memory: 47.5 MB
// Runtime: 16 ms


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
    public int Rob(TreeNode root) {

        var cache = new Dictionary<(TreeNode, bool), int>();

        return Visit(root, false);

        int Visit(TreeNode node, bool parentRobbed)
        {
            if (node==null) {
                return 0;
            }
            var p = (node, parentRobbed);
            int result;
            if (cache.TryGetValue(p, out result)) {
                return result;
            }
            if (parentRobbed) {
                // cannot rob this, so call for children
                result = Visit(node.left, false) + Visit(node.right, false);
            }
            else {
                // can try rob this or not rob it
                var whenRob = node.val + Visit(node.left, true) + Visit(node.right, true);
                var whenNonRob = Visit(node.left, false) + Visit(node.right, false);
                result = Math.Max(whenRob, whenNonRob);
            }
            cache[p] = result;
            return result;
        }        
    }
}
