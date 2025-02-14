// Copyright (c) 2020 Alexey Filatov
// 3 - Longest Substring Without Repeating Characters (https://leetcode.com/problems/longest-substring-without-repeating-characters)
// Date solved: 1/16/2020 5:15:12 PM +00:00
// Memory: 25.6 MB
// Runtime: 80 ms


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length<=1) return s.Length;
        var l = 0;
        var r = 1;
        var maxLen = 1;
        var chars = new HashSet<char>();
        chars.Add(s[l]);
        while(r<s.Length) {        
            if (!chars.Contains(s[r])) {
                chars.Add(s[r]);
                var len = r - l + 1;
                if (len>maxLen) maxLen = len;
            }
            else {
                while(s[l]!=s[r]) {
                    chars.Remove(s[l]);
                    l++;
                }
                l++;
            }            
            r++;
        }
        return maxLen;
    }
}
