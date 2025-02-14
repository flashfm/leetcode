// Copyright (c) 2024 Alexey Filatov
// 459 - Repeated Substring Pattern (https://leetcode.com/problems/repeated-substring-pattern)
// Date solved: 12/17/2024 6:45:09 AM +00:00
// Memory: 61.5 MB
// Runtime: 119 ms


public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(var l=1; l<=s.Length/2; l++) {
            var sub = s.Substring(0, l);
            int i;
            for(i=l; i<=s.Length-sub.Length; i += sub.Length) {
                int c;
                for(c=0; c<l; c++) {
                    if (sub[c]!=s[i+c]) {
                        break;
                    }
                }
                if (c!=l) {
                    break;
                }
            }
            if (i==s.Length) {
                return true;
            }
        }
        return false;
    }
}
