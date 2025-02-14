// Copyright (c) 2024 Alexey Filatov
// 212 - Word Search II (https://leetcode.com/problems/word-search-ii)
// Date solved: 10/8/2024 10:13:59 PM +00:00
// Memory: 51.7 MB
// Runtime: 490 ms


public class Solution {
    private class Node
    {
        public string Word;
        public Node[] ChildByVal = new Node[26];
    }

    private char[][] board;
    private string[] words;
    private HashSet<string> result = new();

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
        
        return result.ToList();
    }

    private void Visit(Node parent, int r, int c)
    {
        if (r<0 || r>=board.Length) {
            return;
        }
        var row = board[r];
        if (c<0 || c>=row.Length) {
            return;
        }
        var ch = row[c];
        if (ch=='#') {
            return;
        }
        var child = parent.ChildByVal[ch-'a'];
        if (child==null) {
            // there is no child node that points to current board letter
            return;
        }
        if (child.Word!=null) {
            result.Add(child.Word);
        }        
        row[c] = '#'; // mark as visited
        Visit(child, r+1, c);
        Visit(child, r-1, c);
        Visit(child, r, c+1);
        Visit(child, r, c-1);
        row[c] = ch;
    }
}
