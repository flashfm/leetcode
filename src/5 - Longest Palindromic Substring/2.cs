// Copyright (c) 2020 Alexey Filatov
// 5 - Longest Palindromic Substring (https://leetcode.com/problems/longest-palindromic-substring)
// Date solved: 1/22/2020 6:01:30 AM +00:00
// Memory: 23.3 MB
// Runtime: 128 ms


public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length==0) return "";
        
        int bestL = 0;
        int bestR = 0;
                
        for(var i=0;i<s.Length;i++) {
            GetPalWithCenter(s, i, false, ref bestL, ref bestR);
            GetPalWithCenter(s, i, true, ref bestL, ref bestR);
        }
        
        return s.Substring(bestL, bestR - bestL + 1);
    }
    private void GetPalWithCenter(string s, int i, bool between, ref int bestL, ref int bestR)
    {
        var l = between ? i : i-1;
        var r = i+1;
        while(l>=0 && r<s.Length && s[l]==s[r]) {
            l--;
            r++;
        }
        l++; r--;
        var len = r - l + 1;
        var bestLen = bestR - bestL + 1;
        if (len>bestLen) {
            bestR = r;
            bestL = l;
        }
    }
}
