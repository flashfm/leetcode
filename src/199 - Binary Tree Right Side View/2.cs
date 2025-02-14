// Copyright (c) 2020 Alexey Filatov
// 199 - Binary Tree Right Side View (https://leetcode.com/problems/binary-tree-right-side-view)
// Date solved: 3/14/2020 6:46:16 AM +00:00
// Memory: 30.6 MB
// Runtime: 248 ms


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
    
    private Dictionary<int, int> dict = new Dictionary<int, int>();
    private int maxLevel = int.MinValue;
        
    public IList<int> RightSideView(TreeNode root) {
        InOrder(root, 0);
        var result = new List<int>();
        for(var i = 0; i<=maxLevel; i++) {
            result.Add(dict[i]);
        }
        return result;
    }
    
    private void InOrder(TreeNode node, int level)
    {
        if (node==null) return;
        if (level>maxLevel) maxLevel = level;
        
        InOrder(node.right, level+1);
        
        if (!dict.ContainsKey(level)) dict[level] = node.val;
        
        InOrder(node.left, level+1);
    }
}
