// Copyright (c) 2024 Alexey Filatov
// 392 - Is Subsequence (https://leetcode.com/problems/is-subsequence)
// Date solved: 8/26/2024 2:33:30 AM +00:00
// Memory: 40 MB
// Runtime: 59 ms


public class Solution {
    public bool IsSubsequence(string s, string t) {
        var i = 0;
        foreach(var c in s) {
            while(i<t.Length && t[i]!=c) {
                i++;
            }
            if (i==t.Length) {
                return false;
            }
            else {
                i++;
            }
        }
        return true;
    }
}
