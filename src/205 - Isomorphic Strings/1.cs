// Copyright (c) 2024 Alexey Filatov
// 205 - Isomorphic Strings (https://leetcode.com/problems/isomorphic-strings)
// Date solved: 9/24/2024 10:07:26 PM +00:00
// Memory: 42.3 MB
// Runtime: 63 ms


public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length!=t.Length) {
            return false;
        }
        var map = new Dictionary<char, char>();        
        for(var i = 0; i<s.Length; i++) {
            var sc = s[i];
            var tc = t[i];
            if (map.TryGetValue(sc, out var mappedChar)) {
                if (mappedChar!=tc) {
                    return false;
                }
            }
            else {
                map[sc] = tc;
            }
        }
        var targets = new HashSet<char>();
        foreach(var v in map.Values) {
            if (targets.Contains(v)) {
                return false;
            }
            else {
                targets.Add(v);
            }
        }
        return true;
    }
}
