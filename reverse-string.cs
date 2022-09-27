// Reverse String
// https://leetcode.com/problems/reverse-string
// Date solved: 03/08/2020 01:53:06 +00:00

public class Solution {
    public void ReverseString(char[] s) {
        if (s==null) return;
        for(var i = 0; i<s.Length/2; i++) {
            var t = s[i];
            s[i] = s[s.Length-1-i];
            s[s.Length-1-i] = t;
        }            
    }
}
