// Copyright (c) 2024 Alexey Filatov
// 6 - Zigzag Conversion (https://leetcode.com/problems/zigzag-conversion)
// Date solved: 8/26/2024 1:40:41 AM +00:00
// Memory: 49.6 MB
// Runtime: 75 ms


public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows<=1) {
            return s;
        }
        var y = 0;
        var dy = 1;
        var rows = new List<char>[numRows];
        for(var i = 0; i<numRows; i++) {
            rows[i] = new List<char>();
        }
        for(var i = 0; i<s.Length; i++) {
            rows[y].Add(s[i]);
            y += dy;
            if (y==numRows-1) {
                dy = -1;
            }
            else if (y==0) {
                dy = 1;
            }
        }
        var sb = new StringBuilder();
        for(var i = 0; i<numRows; i++) {
            foreach(var c in rows[i]) {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
