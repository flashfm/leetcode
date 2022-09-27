// Symmetric Tree
// https://leetcode.com/problems/symmetric-tree
// Date solved: 03/15/2020 22:19:40 +00:00

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
    public bool IsSymmetric(TreeNode root) {
        var current = new List<TreeNode>();
        var newList = new List<TreeNode>();
        current.Add(root);
        while(current.Count>0) {
            foreach(var n in current) {
                if (n!=null) {
                    newList.Add(n.left);
                    newList.Add(n.right);
                }
            }
            
            if (!IsSym(newList)) return false;
            
            var oldCurrent = current;
            
            current = newList;
            
            newList = oldCurrent;
            newList.Clear();
        }
        return true;
    }
    
    private bool IsSym(List<TreeNode> nodes)
    {
        var n = nodes.Count;
        for(var i = 0; i<n/2; i++) {
            var a = nodes[i];
            var b = nodes[n-i-1];
            if (a==null && b!=null) return false;
            if (a!=null && b==null) return false;
            if (a!=null && b!=null && a.val!=b.val) return false;
        }
        return true;
    }
}
