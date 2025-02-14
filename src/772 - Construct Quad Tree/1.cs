// Copyright (c) 2024 Alexey Filatov
// 772 - Construct Quad Tree (https://leetcode.com/problems/construct-quad-tree)
// Date solved: 10/10/2024 5:36:29 AM +00:00
// Memory: 48.9 MB
// Runtime: 82 ms


/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    private int[][] grid;
    public Node Construct(int[][] grid) {
        this.grid = grid;
        return Construct(0, 0, grid.Length);
    }
    private Node Construct(int r, int c, int size)
    {
        if (size==1) {
            return new Node(grid[r][c]==1, true);
        }
        var newSize = size/2;
        var topLeft = Construct(r, c, newSize);
        var topRight = Construct(r, c+newSize, newSize);
        var bottomLeft = Construct(r+newSize, c, newSize);
        var bottomRight = Construct(r+newSize, c+newSize, newSize);
        if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf &&
            topLeft.val==topRight.val &&
            topLeft.val==bottomLeft.val &&
            topLeft.val==bottomRight.val) {
                return new Node(topLeft.val, true);
            }
            else {
                return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
            }
    }
}
