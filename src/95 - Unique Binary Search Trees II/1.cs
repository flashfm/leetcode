// Copyright (c) 2025 Alexey Filatov
// 95 - Unique Binary Search Trees II (https://leetcode.com/problems/unique-binary-search-trees-ii)
// Date solved: 1/7/2025 7:43:18 AM +00:00
// Memory: 44.3 MB
// Runtime: 6 ms


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
    public IList<TreeNode> GenerateTrees(int n) {
        return GenTree(1, n);
    }

    private IList<TreeNode> GenTree(int start, int end)
    {
        if (start>end) {
            return [null];
        }
        var result = new List<TreeNode>();
        for(var i=start; i<=end; i++) {
            foreach(var left in GenTree(start, i-1)) {
                foreach(var right in GenTree(i+1, end)) {
                    var root = new TreeNode(i);
                    root.left = left;
                    root.right = right;
                    result.Add(root);
                }
            }
        }
        return result;
    }
}
