// Copyright (c) 2024 Alexey Filatov
// 1777 - Determine if Two Strings Are Close (https://leetcode.com/problems/determine-if-two-strings-are-close)
// Date solved: 11/10/2024 9:34:47 PM +00:00
// Memory: 50.9 MB
// Runtime: 7 ms


public class Solution {
    public bool CloseStrings(string word1, string word2) {
        var d1 = new int[26];
        foreach(var c in word1) {
            d1[c-'a']++;
        }
        var d2 = new int[26];
        foreach(var c in word2) {
            d2[c-'a']++;
        }
        for(var i = 0; i<26; i++) {
            if ((d1[i]==0 && d2[i]!=0) || (d1[i]!=0 && d2[i]==0)) {
                return false;
            }
        }
        var cc1 = new Dictionary<int, int>();
        foreach(var c in d1) {
            cc1[c] = cc1.GetValueOrDefault(c) + 1;
        }
        var cc2 = new Dictionary<int, int>();
        foreach(var c in d2) {
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
