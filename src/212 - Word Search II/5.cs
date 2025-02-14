// Copyright (c) 2024 Alexey Filatov
// 212 - Word Search II (https://leetcode.com/problems/word-search-ii)
// Date solved: 10/8/2024 10:17:40 PM +00:00
// Memory: 50.9 MB
// Runtime: 322 ms


public class Solution {
    private class Node
    {
        public string Word;
        public Node[] ChildByVal = new Node[26];
    }

    private char[][] board;
    private string[] words;
    private List<string> result = new();

    public IList<string> FindWords(char[][] board, string[] words) {
        this.board = board;
        this.words = words;

        var root = new Node();
        foreach(var word in words) {
            var node = root;
            foreach(var ch in word) {
                var i = ch - 'a';
                node = node.ChildByVal[i] = node.ChildByVal[i] ?? new Node();
            }
            node.Word = word;
        }

        for(var r = 0; r<board.Length; r++) {
            for(var c = 0; c<board[0].Length; c++) {
                Visit(root, r, c);
            }
        }
        
        return result;
    }

    private void Visit(Node parent, int r, int c)
    {
        var ch = board[r][c];
        if (ch=='#') {
            // if visited
            return;
        }
        var child = parent.ChildByVal[ch-'a'];
        if (child==null) {
            // there is no child node that points to current board letter
            return;
        }
        if (child.Word!=null) {
            result.Add(child.Word);
            child.Word = null; // don't find the same word again
        }        
        board[r][c] = '#'; // mark as visited
        if (r>0) {
            Visit(child, r-1, c);
        }
        if (c>0) {
            Visit(child, r, c-1);
        }
        if (r<board.Length-1) {
            Visit(child, r+1, c);
        }
        if (c<board[0].Length-1) {
            Visit(child, r, c+1);
        }
        board[r][c] = ch; // unmark as visited
    }
}
