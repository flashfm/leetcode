// Copyright (c) 2020 Alexey Filatov
// 5 - Longest Palindromic Substring (https://leetcode.com/problems/longest-palindromic-substring)
// Date solved: 1/18/2020 8:47:31 PM +00:00
// Memory: 26.4 MB
// Runtime: 116 ms


public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length==0) return "";
        string result = s[0].ToString();
        
        for(var i=0;i<s.Length;i++) {
            GetPalWithCenter(s, i, false, ref result);
            GetPalWithCenter(s, i, true, ref result);
        }
        
        return result;
    }
    private void GetPalWithCenter(string s, int i, bool between, ref string result)
    {
        var l = between ? i : i-1;
        var r = i+1;
        while(l>=0 && r<s.Length && s[l]==s[r]) {
            l--;
            r++;
        }
        l++; r--;
        var len = r - l + 1;
        if (len>result.Length) result = s.Substring(l, len);
    }
}
