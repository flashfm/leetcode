// Copyright (c) 2024 Alexey Filatov
// 211 - Design Add and Search Words Data Structure (https://leetcode.com/problems/design-add-and-search-words-data-structure)
// Date solved: 10/7/2024 6:14:39 AM +00:00
// Memory: 156.6 MB
// Runtime: 2131 ms


public class WordDictionary {

    private class Node
    {
        public char Val;
        public bool IsLast;
        public List<Node> Children = new();
    }

    private Node root = new Node();

    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        var node = root;
        foreach(var c in word) {
            var child = node.Children.SingleOrDefault(n => n.Val==c);
            if (child==null) {
                child = new Node() {
                    Val = c
                };
                node.Children.Add(child);
            }
            node = child;
        }
        node.IsLast = true;
    }
    
    public bool Search(string word) {
        var layer = root.Children;
        List<Node> oldLayer = null;
        foreach(var c in word) {
            if (c!='.') {
                layer = layer.Where(n => n.Val==c).ToList();
            }
            if (layer.Count==0) {
                return false;
            }
            oldLayer = layer;
            layer = layer.SelectMany(c => c.Children).ToList();
        }
        return oldLayer!=null && oldLayer.Any(c => c.IsLast);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
