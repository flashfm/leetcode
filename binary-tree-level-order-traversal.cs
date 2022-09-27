// Binary Tree Level Order Traversal
// https://leetcode.com/problems/binary-tree-level-order-traversal
// Date solved: 03/18/2020 04:56:52 +00:00

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if (root==null) return result;
        var level = new List<TreeNode>();
        level.Add(root);
        while(level.Count>0) {
            var newLevel = new List<TreeNode>();
            var list = new List<int>();
            result.Add(list);
            foreach(var node in level) {
                list.Add(node.val);
                if (node.left != null) newLevel.Add(node.left);
                if (node.right != null) newLevel.Add(node.right);
            }
            level = newLevel;
        }
        return result;
    }
}
