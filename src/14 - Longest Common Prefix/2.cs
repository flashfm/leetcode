// Copyright (c) 2024 Alexey Filatov
// 14 - Longest Common Prefix (https://leetcode.com/problems/longest-common-prefix)
// Date solved: 10/31/2024 4:24:44 AM +00:00
// Memory: 42.3 MB
// Runtime: 5 ms


public class Solution {
    public string LongestCommonPrefix(string[] strs) {  
        if (strs.Length==0) {
            return "";
        }
        var prefix = new StringBuilder();
        for(var i = 0; i<strs[0].Length; i++) {
            var c = strs[0][i];
            foreach(var s in strs) {
                if (i==s.Length || s[i]!=c) {
                    return prefix.ToString();
                }
            }
            prefix.Append(c);
        }
        return strs[0];
    }
}
