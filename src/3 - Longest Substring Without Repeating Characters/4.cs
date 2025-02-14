// Copyright (c) 2024 Alexey Filatov
// 3 - Longest Substring Without Repeating Characters (https://leetcode.com/problems/longest-substring-without-repeating-characters)
// Date solved: 10/30/2024 3:14:38 AM +00:00
// Memory: 42.3 MB
// Runtime: 9 ms


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var l = 0;
        var r = 0;
        var hashSet = new HashSet<char>();
        var result = 0;
        while(r<s.Length) {
            if (l<=r && hashSet.Contains(s[r])) {
                hashSet.Remove(s[l++]);
            }
            else {
                hashSet.Add(s[r++]);
            }
            result = Math.Max(result, hashSet.Count);
        }
        return result;
    }
}
