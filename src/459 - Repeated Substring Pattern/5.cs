// Copyright (c) 2024 Alexey Filatov
// 459 - Repeated Substring Pattern (https://leetcode.com/problems/repeated-substring-pattern)
// Date solved: 12/17/2024 7:22:04 AM +00:00
// Memory: 51.9 MB
// Runtime: 2 ms


public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        return (s+s).Substring(1, s.Length*2-2).Contains(s);
    }
}
