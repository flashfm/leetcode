// Copyright (c) 2025 Alexey Filatov
// 1437 - Minimum Insertion Steps to Make a String Palindrome (https://leetcode.com/problems/minimum-insertion-steps-to-make-a-string-palindrome)
// Date solved: 1/4/2025 8:50:08 PM +00:00
// Memory: 42.5 MB
// Runtime: 28 ms


public class Solution {
    public int MinInsertions(string s) {

        var n = s.Length;
        var cache = new int[n*n];
        Array.Fill(cache, -1);

        return Get(0, n);

        int Get(int start, int len)
        {
            if (len<=1) {
                return 0;
            }
            var p = start*n+len;
            if (cache[p]!=-1) {
                return cache[p];
            }
            var res = s[start]==s[start+len-1] ? Get(start+1, len-2) :
                1 + Math.Min(Get(start+1, len-1), Get(start, len-1));
            cache[p] = res;
            return res;
        }
    }
}

