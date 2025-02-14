// Copyright (c) 2024 Alexey Filatov
// 2572 - Append Characters to String to Make Subsequence (https://leetcode.com/problems/append-characters-to-string-to-make-subsequence)
// Date solved: 10/28/2024 1:28:00 AM +00:00
// Memory: 44.1 MB
// Runtime: 2 ms


public class Solution {
    public int AppendCharacters(string s, string t) {
        var start = 0;
        var found = 0;
        foreach(var c in t) {
            var i = s.IndexOf(c, start);
            if (i==-1) {
                break;
            }
            found++;
            start = i+1;
        }
        return t.Length - found;
    }
}
