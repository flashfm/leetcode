// Copyright (c) 2024 Alexey Filatov
// 459 - Repeated Substring Pattern (https://leetcode.com/problems/repeated-substring-pattern)
// Date solved: 12/17/2024 6:42:17 AM +00:00
// Memory: 58.1 MB
// Runtime: 128 ms


public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(var l=1; l<=s.Length/2; l++) {
            var sub = s.Substring(0, l);
            int i;
            for(i=l; i<=s.Length-sub.Length; i += sub.Length) {
                var sub1 = s.Substring(i, l);
                if (sub1!=sub) {
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
