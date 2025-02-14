// Copyright (c) 2024 Alexey Filatov
// 1894 - Merge Strings Alternately (https://leetcode.com/problems/merge-strings-alternately)
// Date solved: 11/8/2024 8:12:51 PM +00:00
// Memory: 38.9 MB
// Runtime: 40 ms


public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        var min = Math.Min(word1.Length, word2.Length);
        for(var i = 0; i<min; i++) {
            sb.Append(word1[i]).Append(word2[i]);
        }
        if (word1.Length>min) {
            sb.Append(word1.Substring(min, word1.Length-min));
        }
        if (word2.Length>min) {
            sb.Append(word2.Substring(min, word2.Length-min));
        }
        return sb.ToString();
    }
}
