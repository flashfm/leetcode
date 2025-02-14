// Copyright (c) 2020 Alexey Filatov
// 874 - Backspace String Compare (https://leetcode.com/problems/backspace-string-compare)
// Date solved: 4/10/2020 6:48:02 AM +00:00
// Memory: 22.3 MB
// Runtime: 68 ms


public class Solution {
    public bool BackspaceCompare(string S, string T) {
        var i=S.Length-1;
        var j=T.Length-1;
        while(i>=0 || j>=0) {
            var del = 0;
            while(i>=0) {
                if (S[i]=='#') {
                    del++;
                }
                else {
                    if (del==0) break;
                    del--;
                }
                i--;
            }
            
            del = 0;
            while(j>=0) {
                if(T[j]=='#') {
                    del++;
                }
                else {
                    if (del==0) break;
                    del--;
                }
                j--;
            }
            
            if (i<0 && j>=0) return false;
            if (j<0 && i>=0) return false;
            if (i>=0 && j>=0 && S[i]!=T[j]) return false;
            i--;
            j--;
        }
        return true;
    }
}
