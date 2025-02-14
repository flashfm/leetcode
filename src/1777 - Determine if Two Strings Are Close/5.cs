// Copyright (c) 2024 Alexey Filatov
// 1777 - Determine if Two Strings Are Close (https://leetcode.com/problems/determine-if-two-strings-are-close)
// Date solved: 11/10/2024 9:44:07 PM +00:00
// Memory: 50.4 MB
// Runtime: 5 ms


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
        Array.Sort(d1);
        Array.Sort(d2);
        for(var i = 0; i<26; i++) {
            if (d1[i]!=d2[i]) {
                return false;
            }
        }
        return true;
    }
}
