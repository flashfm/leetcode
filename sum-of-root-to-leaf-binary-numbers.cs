// Sum of Root To Leaf Binary Numbers
// https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers
// Date solved: 09/25/2020 05:06:45 +00:00

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
        private int result;
        public int SumRootToLeaf(TreeNode root) {
            if (root==null) {
                return 0;
            }
            Sum(root, 0);
            return result;
        }
        private void Sum(TreeNode node, int soFar)
        {
            if (node==null) return;
            
            var v = (soFar << 1) + node.val;
            
            if (node.left==null && node.right==null) {
                result += v;
            }
            else {
                Sum(node.left, v);
                Sum(node.right, v);
            }
        }
    }

