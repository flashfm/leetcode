// Copyright (c) 2024 Alexey Filatov
// 212 - Word Search II (https://leetcode.com/problems/word-search-ii)
// Date solved: 10/8/2024 10:02:46 PM +00:00
// Memory: 129.4 MB
// Runtime: 2314 ms


public class Solution {
    private class Node
    {
        public char Val;
        public string Word;
        public Node[] ChildByVal = new Node[26];
    }

    private char[][] board;
    private string[] words;
    private HashSet<string> result = new();

    public IList<string> FindWords(char[][] board, string[] words) {
        this.board = board;
        this.words = words;

        var root = BuildRoot();

        for(var r = 0; r<board.Length; r++) {
            for(var c = 0; c<board[0].Length; c++) {
                foreach(var child in root.ChildByVal.Where(c => c != null)) {
                    Visit(child, r, c);
                }
            }
        }
        
        return result.ToList();
    }

    private Node BuildRoot()
    {
        var root = new Node();
        foreach(var word in words) {
            var node = root;
            foreach(var ch in word) {
                var i = ch - 'a';
                node = node.ChildByVal[i] ?? (node.ChildByVal[i] = new Node { Val = ch });
            }
            node.Word = word;
        }
        return root;
    }

    private void Visit(Node node, int r, int c)
    {
        if (node==null) {
            return;
        }
        if (r<0 || r>=board.Length) {
            return;
        }
        var row = board[r];
        if (c<0 || c>=row.Length) {
            return;
        }
        if (row[c]!=node.Val) {
            return;
        }
        if (node.Word!=null) {
            result.Add(node.Word);
        }        
        row[c] = '#';
        foreach(var child in node.ChildByVal.Where(c => c!=null)) {
            Visit(child, r+1, c);
            Visit(child, r-1, c);
            Visit(child, r, c+1);
            Visit(child, r, c-1);
        }
        row[c] = node.Val;
    }
}
