// Binary Tree Inorder Traversal
// https://leetcode.com/problems/binary-tree-inorder-traversal
// Date solved: 12/22/2019 07:28:12 +00:00

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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root==null) {
            return new int[0];
        }
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var curr = root;
        while(curr!=null || stack.Count>0) {
            while(curr!=null) {
                stack.Push(curr);
                curr = curr.left;
            }
            curr = stack.Pop();
            result.Add(curr.val);
            curr = curr.right;
        }
        return result;
    }
}
