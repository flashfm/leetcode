// Copyright (c) 2020 Alexey Filatov
// 437 - Path Sum III (https://leetcode.com/problems/path-sum-iii)
// Date solved: 8/11/2020 5:45:46 AM +00:00
// Memory: 47.2 MB
// Runtime: 176 ms


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
    private Dictionary<TreeNode, Dictionary<int, int>> nextDesiredValuesByNode = new Dictionary
        <TreeNode, Dictionary<int, int>>();
    private int result = 0;
    private int sum;
    public int PathSum(TreeNode root, int sum) {
        if (root==null) {
            return 0;
        }
        this.sum = sum;
        ProcessNode(null, root);
        Traverse(root);
        return result;
    }
    private void Traverse(TreeNode node)
    {
        if (node.left!=null) {
            ProcessNode(node, node.left);
            Traverse(node.left);
        }    
        if (node.right!=null) {
            ProcessNode(node, node.right);
            Traverse(node.right);
        }
    }
    private void ProcessNode(TreeNode parent, TreeNode node)
    {
        if (node.val==sum) {
            result++;
        }
        AddDesiredValue(node, sum - node.val);
        if (parent==null) {
            return;
        }
        if (!nextDesiredValuesByNode.TryGetValue(parent, out var desired)) {
            return;
        }
        if (desired.TryGetValue(node.val, out var count)) {
            result += count;
        }
        foreach(var pair in desired) {
            AddDesiredValue(node, pair.Key - node.val, pair.Value);
        }
    }    
    private void AddDesiredValue(TreeNode node, int val, int excount = 1)
    {
        if (!nextDesiredValuesByNode.TryGetValue(node, out var dict)) {
            nextDesiredValuesByNode[node] = dict = new Dictionary<int, int>();
        }
        if (!dict.TryGetValue(val, out var count)) {
            count = 0;
        }
        dict[val] = count + excount;
    }
}
