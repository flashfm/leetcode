// Copyright (c) 2024 Alexey Filatov
// 438 - Find All Anagrams in a String (https://leetcode.com/problems/find-all-anagrams-in-a-string)
// Date solved: 12/10/2024 11:46:30 PM +00:00
// Memory: 50.9 MB
// Runtime: 10 ms


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
            current[s[r]-'a']++;
        }
        if (current.SequenceEqual(allowed)) {
            result.Add(0);
        }
        for(var l=1; l<=s.Length-n; l++) {
            var r = l+n-1;
            current[s[l-1]-'a']--;
            current[s[r]-'a']++;
            if (current.SequenceEqual(allowed)) {
                result.Add(l);
            }
        }
        return result;
    }
}
