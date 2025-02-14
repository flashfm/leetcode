// Copyright (c) 2024 Alexey Filatov
// 151 - Reverse Words in a String (https://leetcode.com/problems/reverse-words-in-a-string)
// Date solved: 11/9/2024 3:13:31 AM +00:00
// Memory: 40.6 MB
// Runtime: 3 ms


public class Solution {
    public string ReverseWords(string s) {
        var n = s.Length;
        var a = s.ToArray();
        // extra space remove
        var l = 0;
        var r = 0;
        while(r<n && a[r]==' ') { r++; }
        while(r<n) {
            a[l] = a[r];
            if (a[r]!=' ' || (r+1<n && a[r+1]!=' ')) {
                l++;
            }
            r++;
        }
        n = l;
        // reverse
        for(var i = 0; i<n/2; i++) {
            (a[i], a[n-1-i]) = (a[n-1-i], a[i]);
        }
        // each word reverse
        l = 0;
        for(r = 0; r<n; r++) {
            if (a[r]==' ') {
                l = r+1;
            }
            else if (l<=r && (r==n-1 || a[r+1] == ' ')) {
                // word is between l and r
                for(var j=0; j<=(r-l)/2; j++) {
                    (a[l+j], a[r-j]) = (a[r-j], a[l+j]);
                }
            }
        }
        return new string(a, 0, n);
    }
}
