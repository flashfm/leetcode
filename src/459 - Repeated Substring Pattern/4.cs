// Copyright (c) 2024 Alexey Filatov
// 459 - Repeated Substring Pattern (https://leetcode.com/problems/repeated-substring-pattern)
// Date solved: 12/17/2024 7:05:41 AM +00:00
// Memory: 46.7 MB
// Runtime: 3 ms


public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(var l=1; l<=s.Length/2; l++) {
            if (s.Length%l!=0) {
                continue;
            }
            int i;
            for(i=l; i<=s.Length-l; i += l) {
                int c;
                for(c=0; c<l; c++) {
                    if (s[c]!=s[i+c]) {
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
