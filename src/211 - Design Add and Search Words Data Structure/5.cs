// Copyright (c) 2024 Alexey Filatov
// 211 - Design Add and Search Words Data Structure (https://leetcode.com/problems/design-add-and-search-words-data-structure)
// Date solved: 10/7/2024 6:32:55 AM +00:00
// Memory: 211 MB
// Runtime: 1069 ms


public class WordDictionary {

    private class Node
    {
        public char Val;
        public bool IsLast;
        public Dictionary<char, Node> Children = new();
    }

    private Node root = new Node();

    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        var node = root;
        foreach(var c in word) {
            var child = node.Children.GetValueOrDefault(c);
            if (child==null) {
                child = new Node() {
                    Val = c
                };
                node.Children[c] = child;
            }
            node = child;
        }
        node.IsLast = true;
    }
    
    public bool Search(string word) {
        return Search(root, word, 0);
    }

    private bool Search(Node start, string word, int wordStart)
    {
        Node cur = start;
        for(var i = wordStart; i<word.Length; i++) {
            var c = word[i];
            if (c=='.') {
                foreach(var child in cur.Children.Values) {
                    if (Search(child, word, i+1)) {
                        return true;
                    }
                }
                return false;
            }
            cur = cur.Children.GetValueOrDefault(c);
            if (cur==null) {
                return false;
            }
        }
        return cur!=null && cur.IsLast;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
