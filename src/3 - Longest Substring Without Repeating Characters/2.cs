// Copyright (c) 2020 Alexey Filatov
// 3 - Longest Substring Without Repeating Characters (https://leetcode.com/problems/longest-substring-without-repeating-characters)
// Date solved: 1/18/2020 5:08:37 AM +00:00
// Memory: 25.8 MB
// Runtime: 100 ms


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        var chars = new HashSet<char>();
        var i = 0;
        var j = 0;
        var n = s.Length;
        var result = 0;
        while(i<n && j<n) {
            if (!chars.Contains(s[j])) {
                chars.Add(s[j++]);
                result = Math.Max(result, j-i);
            }
            else {
                chars.Remove(s[i++]);
            }
        }

        return result;
    }
}
