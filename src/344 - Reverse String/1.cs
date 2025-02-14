// Copyright (c) 2020 Alexey Filatov
// 344 - Reverse String (https://leetcode.com/problems/reverse-string)
// Date solved: 3/8/2020 1:53:06 AM +00:00
// Memory: 34.7 MB
// Runtime: 392 ms


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
