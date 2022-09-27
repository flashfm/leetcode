// Maximum Width of Binary Tree
// https://leetcode.com/problems/maximum-width-of-binary-tree
// Date solved: 07/23/2020 06:01:53 +00:00

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
    public int WidthOfBinaryTree(TreeNode root) {
        if (root==null) return 0;
        var coord = new Dictionary<TreeNode, long>();
        coord[root] = 0;
        var level = new List<TreeNode>();
        level.Add(root);
        var result = 1;
        while(level.Count>0) {
            var newLevel = new List<TreeNode>(level.Count*2);
            long min = long.MaxValue;
            long max = long.MinValue;
            foreach(var n in level) {
                var x = coord[n];
                if (n.left!=null) {
                    min = Math.Min(min, 2*x);
                    max = Math.Max(max, 2*x);
                    coord[n.left] = 2*x;
                    newLevel.Add(n.left);
                }
                if (n.right!=null) {
                    min = Math.Min(min, 2*x+1);
                    max = Math.Max(max, 2*x+1);
                    coord[n.right] = 2*x+1;
                    newLevel.Add(n.right);
                }
            }            
            if (max>long.MinValue) result = Math.Max(result, (int)(max - min + 1));
            level = newLevel;
        }
        return result;
    }
}
