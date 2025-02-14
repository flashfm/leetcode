// Copyright (c) 2024 Alexey Filatov
// 1397 - Search Suggestions System (https://leetcode.com/problems/search-suggestions-system)
// Date solved: 11/26/2024 12:39:07 AM +00:00
// Memory: 81.2 MB
// Runtime: 14 ms


public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products);
        var layer = products;
        var result = new List<IList<string>>();
        for(var i = 0; i<searchWord.Length; i++) {
            layer = layer.Where(p => i<p.Length && p[i]==searchWord[i]).ToArray();
            result.Add(layer.Take(3).ToArray());
        }
        return result;
    }
}
