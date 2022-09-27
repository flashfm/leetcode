// Binary Tree Level Order Traversal II
// https://leetcode.com/problems/binary-tree-level-order-traversal-ii
// Date solved: 07/19/2020 10:48:17 +00:00

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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var result = new List<IList<int>>();
        if (root==null) return result;
        var level = new List<TreeNode>();
        level.Add(root);
        while (level.Count>0) {
            var newLevel = new List<TreeNode>();
            var row = new List<int>();
            result.Add(row);
            foreach(var n in level) {
                row.Add(n.val);
                if (n.left!=null)
                    newLevel.Add(n.left);            
                if (n.right!=null)
                    newLevel.Add(n.right);            
            }
            level = newLevel;
        }
        result.Reverse();
        return result;
    }
}
