// Copyright (c) 2024 Alexey Filatov
// 1397 - Search Suggestions System (https://leetcode.com/problems/search-suggestions-system)
// Date solved: 11/26/2024 1:06:04 AM +00:00
// Memory: 133.4 MB
// Runtime: 73 ms


public class Solution {
    public class MaxComparer: IComparer<string>
    {
        public int Compare(string a, string b) => b.CompareTo(a);
    }

    private static MaxComparer comparer = new();

    public class Node
    {
        public Node[] Children { get; set; } = new Node[26];
        public PriorityQueue<string, string> Words { get; set; } = new PriorityQueue<string, string>(comparer);
    }

    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
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
                child.Words.Enqueue(product, product);
                if (child.Words.Count>3) {
                    child.Words.Dequeue();
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
            if (child!=null) {
                var list = new List<string>();
                while(child.Words.Count>0) {
                    list.Add(child.Words.Dequeue());
                }
                list.Reverse();
                result.Add(list);
            }
            else {
                result.Add([]);
            }
            node = child;
        }
        return result;
    }
}
