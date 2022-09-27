// Maximum Difference Between Node and Ancestor
// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor
// Date solved: 11/10/2020 03:55:03 +00:00

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

/*

|A.val - B.val| and A is an ancestor of B

*/
public class Solution {
    int maxDiff = 0;
    public int MaxAncestorDiff(TreeNode root) {
        GetMinMax(root);
        return maxDiff;
    }
    
    private (int Min, int Max) GetMinMax(TreeNode node)
    {
        var l = node.left!=null ? GetMinMax(node.left) : (Min: node.val, Max: node.val);
        var r = node.right!=null ? GetMinMax(node.right) : (Min: node.val, Max: node.val);
    
        maxDiff = Math.Max(maxDiff, Math.Abs(node.val - l.Min));
        maxDiff = Math.Max(maxDiff, Math.Abs(node.val - l.Max));
        maxDiff = Math.Max(maxDiff, Math.Abs(node.val - r.Min));
        maxDiff = Math.Max(maxDiff, Math.Abs(node.val - r.Max));
        var max = Math.Max(node.val, Math.Max(l.Max, r.Max));
        var min = Math.Min(node.val, Math.Min(l.Min, r.Min));        
        //Console.WriteLine(node.val+","+maxDiff);
        
        return (min, max);
    }
}
