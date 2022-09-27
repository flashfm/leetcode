// Convert Sorted Array to Binary Search Tree
// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
// Date solved: 03/20/2020 07:27:50 +00:00

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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BuildBST(nums, 0, nums.Length-1);
    }
    private TreeNode BuildBST(int[] nums, int l, int r)
    {
        if (l>r) return null;
        var mid = l + (r-l)/2;
        var node = new TreeNode(nums[mid]);
        node.left = BuildBST(nums, l, mid-1);
        node.right = BuildBST(nums, mid+1, r);
        return node;
    }
}
