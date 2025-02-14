// Copyright (c) 2024 Alexey Filatov
// 438 - Find All Anagrams in a String (https://leetcode.com/problems/find-all-anagrams-in-a-string)
// Date solved: 12/10/2024 11:44:07 PM +00:00
// Memory: 50.3 MB
// Runtime: 6 ms


public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var n = p.Length;
        var result = new List<int>();
        if (n>s.Length) {
            return result;
        }
        var allowed = new int[26];
        foreach(var c in p) {
            allowed[c-'a']++;
        }
        var current = new int[26];
        for(var r=0; r<n; r++) {
            Add(r);
        }
        if (Ok()) {
            result.Add(0);
        }
        for(var l=1; l<=s.Length-n; l++) {
            var r = l+n-1;
            Remove(l-1);
            Add(r);
            if (Ok()) {
                result.Add(l);
            }
        }
        return result;

        void Add(int i) => current[s[i]-'a']++;
        void Remove(int i) => current[s[i]-'a']--;
        bool Ok()
        {
            for(var i = 0; i<26; i++) {
                if (allowed[i]!=current[i]) {
                    return false;
                }
            }
            return true;
        }
    }
}
