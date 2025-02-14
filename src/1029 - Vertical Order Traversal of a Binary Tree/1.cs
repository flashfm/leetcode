// Copyright (c) 2020 Alexey Filatov
// 1029 - Vertical Order Traversal of a Binary Tree (https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree)
// Date solved: 8/8/2020 6:43:18 AM +00:00
// Memory: 31.1 MB
// Runtime: 248 ms


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
    public struct Coord {
        public int X;
        public int Y;
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    private Dictionary<TreeNode, Coord> coordByNode = new Dictionary<TreeNode, Coord>();
    private Dictionary<int, List<TreeNode>> nodesByX = new Dictionary<int, List<TreeNode>>();
    
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var result = new List<IList<int>>();
        coordByNode[root] = new Coord();
        BuildCoords(root);
        
        var xs = nodesByX.Keys.ToList();
        xs.Sort();
        foreach(var x in xs) {
            var nodes = nodesByX[x];
            result.Add(nodes.OrderByDescending(n => coordByNode[n].Y).ThenBy(n => n.val).Select(n => n.val).ToList());
        }
        return result;
    }
    
    private void BuildCoords(TreeNode node)
    {
        var coord = coordByNode[node];
        if (!nodesByX.TryGetValue(coord.X, out var list)) {
            nodesByX[coord.X] = list = new List<TreeNode>();
        }
        list.Add(node);
        
        if (node.left!=null) {
            coordByNode[node.left] = new Coord(coord.X-1, coord.Y-1);
            BuildCoords(node.left);            
        }
        if (node.right!=null) {
            coordByNode[node.right] = new Coord(coord.X+1, coord.Y-1);
            BuildCoords(node.right);
        }
    }
}
