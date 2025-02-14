// Copyright (c) 2024 Alexey Filatov
// 742 - To Lower Case (https://leetcode.com/problems/to-lower-case)
// Date solved: 12/17/2024 10:25:07 PM +00:00
// Memory: 39.3 MB
// Runtime: 0 ms


public class Solution {
    public string ToLowerCase(string s) {
        var n = s.Length;
        var a = new char[n];
        for(var i=0; i<n; i++) {
            var c = s[i];
            a[i] = c>='A' && c<='Z' ? (char)('a'-'A'+c) : c;
        }
        return new string(a);
    }
}
