// Copyright (c) 2024 Alexey Filatov
// 443 - String Compression (https://leetcode.com/problems/string-compression)
// Date solved: 11/10/2024 2:47:16 AM +00:00
// Memory: 63.5 MB
// Runtime: 0 ms


public class Solution {
    public int Compress(char[] chars) {
        var n = chars.Length;
        var l = 0;
        var r = 0;
        while(r<n) {
            var len = 1;
            while(r+1<n && chars[r]==chars[r+1]) {
                r++;
                len++;
            }
            chars[l++] = chars[r++];
            if (len>1) {
                var s = len.ToString();
                for(var i=0; i<s.Length; i++) {
                    chars[l++] = s[i];
                }
            }
        }
        return l;
    }
}
