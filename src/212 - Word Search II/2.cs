// Copyright (c) 2024 Alexey Filatov
// 212 - Word Search II (https://leetcode.com/problems/word-search-ii)
// Date solved: 10/8/2024 9:55:34 PM +00:00
// Memory: 51.9 MB
// Runtime: 2118 ms


public class Solution {
    private class Node
    {
        public char Val;
        public string Word;
        public (int, int) Pos;
        public Dictionary<char, Node> ChildByVal = new();
    }

    private char[][] board;
    private string[] words;
    private HashSet<string> result = new();

    public IList<string> FindWords(char[][] board, string[] words) {
        this.board = board;
        this.words = words;

        var (r1, n1) = BuildRoot(1);
        // var (r2, n2) = BuildRoot(-1);
        var root = r1;
        // if (n2<n1) {
        //     root = r2;
        // }

        for(var r = 0; r<board.Length; r++) {
            for(var c = 0; c<board[0].Length; c++) {
                foreach(var child in root.ChildByVal.Values) {
                    Visit(child, (r, c));
                }
            }
        }
        
        return result.ToList();
    }

    private (Node, int) BuildRoot(int d)
    {
        var j = 0;
        var root = new Node();
        foreach(var word in words) {
            var node = root;
            var start = d == 1 ? 0 : word.Length-1;
            for(var i = start; i>=0 && i<word.Length; i=i+d) {
                var ch = word[i];
                var child = node.ChildByVal.GetValueOrDefault(ch);
                if (child==null) {
                    node.ChildByVal[ch] = child = new Node { Val = ch };
                    j++;
                }
                node = child;
            }
            node.Word = word;
        }
        return (root, j);
    }

    private void Visit(Node node, (int,int) pos)
    {
        var (r, c) = pos;
        if (r<0 || r>=board.Length) {
            return;
        }
        var row = board[r];
        if (c<0 || c>=row.Length) {
            return;
        }
        if (row[c]=='#') {
            return;
        }
        if (row[c]!=node.Val) {
            return;
        }
        if (node.Word!=null) {
            result.Add(node.Word);
        }        
        row[c] = '#';
        foreach(var child in node.ChildByVal.Values) {
            Visit(child, (r+1, c));
            Visit(child, (r-1, c));
            Visit(child, (r, c+1));
            Visit(child, (r, c-1));
        }
        row[c] = node.Val;
    }
}
