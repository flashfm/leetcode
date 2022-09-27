// Longest Palindromic Substring
// https://leetcode.com/problems/longest-palindromic-substring
// Date solved: 01/18/2020 20:47:31 +00:00

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
