// Copyright (c) 2024 Alexey Filatov
// 5 - Longest Palindromic Substring (https://leetcode.com/problems/longest-palindromic-substring)
// Date solved: 11/1/2024 11:28:14 PM +00:00
// Memory: 40.1 MB
// Runtime: 9 ms


public class Solution {
    public string LongestPalindrome(string s) {
        var maxLen = 0;
        var l = 0;
        var r = 0;
        for(var i = 0; i<s.Length; i++) {
            for(var j = 0; j<=1; j++) {
                var l1 = i;
                var r1 = i+j;
                while(l1>=0 && r1<s.Length && s[l1]==s[r1]) {
                   l1--;
                   r1++;
                }
                l1++; r1--;
                var d1 = r1-l1+1;
                if (d1>maxLen) {
                    (maxLen, l, r) = (d1, l1, r1);
                }
            }
        }
        return s.Substring(l, r-l+1);
    }
}
