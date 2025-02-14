// Copyright (c) 2024 Alexey Filatov
// 1397 - Search Suggestions System (https://leetcode.com/problems/search-suggestions-system)
// Date solved: 11/26/2024 1:08:41 AM +00:00
// Memory: 122.7 MB
// Runtime: 34 ms


public class Solution {
    public class Node
    {
        public Node[] Children { get; set; } = new Node[26];
        public List<string> Words { get; set; } = new();
    }

    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products);
        // build trie
        var root = new Node();
        var node = root;
        foreach(var product in products) {
            node = root;
            foreach(var c in product) {
                var child = node.Children[c-'a'];
                if (child==null) {
                    child = node.Children[c-'a'] = new Node();
                }
                if (child.Words.Count<3) {
                    child.Words.Add(product);
                }
                node = child;
            }
        }
        // go through
        var result = new List<IList<string>>();
        node = root;
        for(var i = 0; i<searchWord.Length; i++) {
            var c = searchWord[i];
            var child = node?.Children[c-'a'];
            result.Add(child?.Words ?? []);
            node = child;
        }
        return result;
    }
}
