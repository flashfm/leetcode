// Copyright (c) 2024 Alexey Filatov
// 1777 - Determine if Two Strings Are Close (https://leetcode.com/problems/determine-if-two-strings-are-close)
// Date solved: 11/10/2024 9:40:04 PM +00:00
// Memory: 51 MB
// Runtime: 8 ms


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
        foreach(var c in d2) {
            var val = cc1[c] = cc1.GetValueOrDefault(c) - 1;
            if (val==0) {
                cc1.Remove(c);
            }
        }
        return cc1.Count==0;
    }
}
