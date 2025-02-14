// Copyright (c) 2024 Alexey Filatov
// 1777 - Determine if Two Strings Are Close (https://leetcode.com/problems/determine-if-two-strings-are-close)
// Date solved: 11/10/2024 8:41:00 PM +00:00
// Memory: 50.9 MB
// Runtime: 44 ms


public class Solution {
    public bool CloseStrings(string word1, string word2) {
        var d1 = new Dictionary<char, int>();
        foreach(var c in word1) {
            d1[c] = d1.GetValueOrDefault(c) + 1;
        }
        var d2 = new Dictionary<char, int>();
        foreach(var c in word2) {
            d2[c] = d2.GetValueOrDefault(c) + 1;
        }
        if (d1.Count!=d2.Count) {
            return false;
        }
        foreach(var k in d1.Keys) {
            if (!d2.ContainsKey(k)) {
                return false;
            }
        }
        var cc1 = new Dictionary<int, int>();
        foreach(var c in d1.Values) {
            cc1[c] = cc1.GetValueOrDefault(c) + 1;
        }
        var cc2 = new Dictionary<int, int>();
        foreach(var c in d2.Values) {
            cc2[c] = cc2.GetValueOrDefault(c) + 1;
        }
        if (cc1.Count!=cc2.Count) {
            return false;
        }
        foreach(var (k,v) in cc1) {
            if (!cc2.TryGetValue(k, out var v2) || v!=v2) {
                return false;
            }
        }
        return true;
    }
}
