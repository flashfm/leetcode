// Copyright (c) 2024 Alexey Filatov
// 14 - Longest Common Prefix (https://leetcode.com/problems/longest-common-prefix)
// Date solved: 10/31/2024 4:25:57 AM +00:00
// Memory: 42.2 MB
// Runtime: 1 ms


public class Solution {
    public string LongestCommonPrefix(string[] strs) {  
        if (strs.Length==0) {
            return "";
        }
        var first = strs[0];
        for(var i = 0; i<first.Length; i++) {
            var c = first[i];
            foreach(var s in strs) {
                if (i==s.Length || s[i]!=c) {
                    return first.Substring(0, i);
                }
            }
        }
        return first;
    }
}
