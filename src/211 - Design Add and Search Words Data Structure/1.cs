// Copyright (c) 2024 Alexey Filatov
// 211 - Design Add and Search Words Data Structure (https://leetcode.com/problems/design-add-and-search-words-data-structure)
// Date solved: 10/7/2024 6:02:41 AM +00:00
// Memory: 156.8 MB
// Runtime: 2136 ms


public class WordDictionary {

    private class Node
    {
        public char Val;
        public bool IsLast;
        public List<Node> Next = new();
    }

    private Node root = new Node();

    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        var node = root;
        foreach(var c in word) {
            var next = node.Next.SingleOrDefault(n => n.Val==c);
            if (next==null) {
                next = new Node() {
                    Val = c
                };
                node.Next.Add(next);
            }
            node = next;
        }
        node.IsLast = true;
    }
    
    public bool Search(string word) {
        var layer = root.Next;
        List<Node> oldLayer = null;
        foreach(var c in word) {
            if (c!='.') {
                layer = layer.Where(n => n.Val==c).ToList();
            }
            if (layer.Count==0) {
                return false;
            }
            oldLayer = layer;
            layer = layer.SelectMany(c => c.Next).ToList();
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
