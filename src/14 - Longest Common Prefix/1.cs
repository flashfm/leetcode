// Copyright (c) 2024 Alexey Filatov
// 14 - Longest Common Prefix (https://leetcode.com/problems/longest-common-prefix)
// Date solved: 2/24/2024 6:13:06 PM +00:00
// Memory: 42 MB
// Runtime: 68 ms


public class Solution {
    public string LongestCommonPrefix(string[] strs) {  
        if (strs.Length==0) {
            return "";
        }
        var ci = GetCommonIndex(strs);
        if (ci==-1) {
            return "";
        }
        return strs[0].Substring(0, ci+1);
    }
    private int GetCommonIndex(string[] strs)
    {
        for(var ci = 0; ci < strs[0].Length; ci++) {
            for (var i = 1; i<strs.Length; i++) {
                var s = strs[i];
                if (ci == s.Length || s[ci]!=strs[0][ci]) {
                    return ci-1;
                }
            } 
        }
        return strs[0].Length-1;
    }
}
