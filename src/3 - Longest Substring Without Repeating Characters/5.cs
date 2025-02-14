// Copyright (c) 2024 Alexey Filatov
// 3 - Longest Substring Without Repeating Characters (https://leetcode.com/problems/longest-substring-without-repeating-characters)
// Date solved: 10/30/2024 8:47:15 PM +00:00
// Memory: 43 MB
// Runtime: 5 ms


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var l = 0;
        var r = 0;
        var posByChar = new Dictionary<char, int>();
        var result = 0;
        while(r<s.Length) {
            var c = s[r];

            if (posByChar.TryGetValue(c, out var lastPos)) {
                l = Math.Max(l, lastPos+1);
            }

            posByChar[c] = r;

            result = Math.Max(result, r-l+1);

            r++;
        }
        return result;
    }
}
