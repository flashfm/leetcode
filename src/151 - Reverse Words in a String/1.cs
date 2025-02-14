// Copyright (c) 2024 Alexey Filatov
// 151 - Reverse Words in a String (https://leetcode.com/problems/reverse-words-in-a-string)
// Date solved: 8/26/2024 12:59:36 AM +00:00
// Memory: 41 MB
// Runtime: 50 ms


public class Solution {
    public string ReverseWords(string s) {
        var words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        return string.Join(' ', words.Reverse());
    }
}
