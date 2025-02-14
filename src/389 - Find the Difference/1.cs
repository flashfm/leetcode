// Copyright (c) 2020 Alexey Filatov
// 389 - Find the Difference (https://leetcode.com/problems/find-the-difference)
// Date solved: 9/25/2020 5:13:02 AM +00:00
// Memory: 24.8 MB
// Runtime: 92 ms


public class Solution {
    public char FindTheDifference(string s, string t) {
         var dict = new Dictionary<char, int>();
        foreach(var c in s) {
            dict.TryGetValue(c, out var i);
            dict[c] = i+1;
        }
        foreach(var c in t) {
            if (!dict.TryGetValue(c, out var i)) {
                return c;
            }
            i--;
            if (i==0) {
                dict.Remove(c);
            }
            else {
                dict[c] = i;
            }
        }
        throw new Exception("unexpected");
    }
}
