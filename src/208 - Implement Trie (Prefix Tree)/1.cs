// Copyright (c) 2022 Alexey Filatov
// 208 - Implement Trie (Prefix Tree) (https://leetcode.com/problems/implement-trie-prefix-tree)
// Date solved: 10/13/2022 6:52:21 AM +00:00
// Memory: 71.7 MB
// Runtime: 255 ms


public class Trie {

    private class Node
    {
        public bool IsEndOfWord {get;set;}
        public Dictionary<char, Node> Children {get;set;} = new();
    }

    private Node root = new();

    public Trie() {
        
    }
    
    public void Insert(string word) {
        var node = root;
        foreach(char c in word) {
            if (!node.Children.TryGetValue(c, out var child)) {
                node.Children[c] = child = new Node();
            }
            node = child;            
        }
        node.IsEndOfWord = true;
    }
    
    public bool Search(string word) {
        var node = root;
        foreach(char c in word) {
            if (!node.Children.TryGetValue(c, out node)) {
                return false;
            }
        }
        return node.IsEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = root;
        foreach(char c in prefix) {
            if (!node.Children.TryGetValue(c, out node)) {
                return false;
            }
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
