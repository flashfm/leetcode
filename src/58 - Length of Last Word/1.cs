// Copyright (c) 2024 Alexey Filatov
// 58 - Length of Last Word (https://leetcode.com/problems/length-of-last-word)
// Date solved: 8/26/2024 12:55:19 AM +00:00
// Memory: 39.9 MB
// Runtime: 42 ms


public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        var i = s.LastIndexOf(" ");
        return i==-1 ? s.Length : s.Length-i-1;
    }
}
