// Valid Palindrome
// https://leetcode.com/problems/valid-palindrome
// Date solved: 03/19/2020 05:29:35 +00:00

public class Solution {
    public bool IsPalindrome(string s) {
        var n = s.Length;
        var l = 0;
        var r = n-1;
        while(l<r) {
            while (!IsAlpha(s[l]) && l<r) l++;
            while (!IsAlpha(s[r]) && l<r) r--;            
            if (l<r && Lower(s[l])!=Lower(s[r])) return false;
            l++;
            r--;
        }
        return true;
    }
    private bool IsAlpha(char c)
    {
        return (c >= 'A' && c<='Z') || (c>='a' && c<='z') || (c>='0' && c<='9');
    }
    private char Lower(char c)
    {
        return (c >= 'A' && c<='Z') ? (char)('a'+c-'A') : c;
    }
}
