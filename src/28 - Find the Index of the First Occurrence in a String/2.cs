// Copyright (c) 2020 Alexey Filatov
// 28 - Find the Index of the First Occurrence in a String (https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string)
// Date solved: 3/21/2020 5:39:25 AM +00:00
// Memory: 22.3 MB
// Runtime: 60 ms


public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length==0) return 0;
        var i = 0;
        for(var s = 0; s<haystack.Length-needle.Length+1; s++) {
            i=0;
            while(i<needle.Length && haystack[s+i]==needle[i]) i++;
            if (i==needle.Length) return s;
        }
        return -1;
    }
    private bool Match(string haystack, int s, string needle)
    {
        for(var i=0;i<needle.Length;i++) {
            if (haystack[s+i]!=needle[i]) return false;
        }
        return true;
    }
}
