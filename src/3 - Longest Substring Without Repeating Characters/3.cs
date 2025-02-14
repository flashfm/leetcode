// Copyright (c) 2020 Alexey Filatov
// 3 - Longest Substring Without Repeating Characters (https://leetcode.com/problems/longest-substring-without-repeating-characters)
// Date solved: 1/18/2020 5:26:57 AM +00:00
// Memory: 25.9 MB
// Runtime: 76 ms


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var result = 0;
        var map = new Dictionary<char, int>();
        for(int i=0, j=0; j<s.Length; j++) {
            if (map.ContainsKey(s[j])) {
                i = Math.Max(i, map[s[j]]);
            }
            result = Math.Max(result, j-i+1);
            map[s[j]] = j+1;
        }
        return result;
    }
}
