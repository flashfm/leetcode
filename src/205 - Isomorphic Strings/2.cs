// Copyright (c) 2024 Alexey Filatov
// 205 - Isomorphic Strings (https://leetcode.com/problems/isomorphic-strings)
// Date solved: 9/24/2024 10:11:36 PM +00:00
// Memory: 41.9 MB
// Runtime: 68 ms


public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var m1 = new int[256];
        var m2 = new int[256];
        for(var i = 0; i<s.Length; i++) {
            var sc = (int)s[i];
            var tc = (int)t[i];
            if (m1[sc]!=m2[tc]) {
                return false;
            }
            m1[sc] = m2[tc] = i+1;
        }
        return true;
    }
}
