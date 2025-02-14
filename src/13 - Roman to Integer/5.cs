// Copyright (c) 2020 Alexey Filatov
// 13 - Roman to Integer (https://leetcode.com/problems/roman-to-integer)
// Date solved: 3/18/2020 5:49:11 AM +00:00
// Memory: 25.7 MB
// Runtime: 80 ms


public class Solution {
    public int RomanToInt(string s) {
        var map = new Dictionary<char, int> {
            {'I',             1},
            {'V',             5},
            {'X',            10},
            {'L',             50},
            {'C',             100},
            {'D',             500},
            {'M',             1000}
        };
        var result = map[s[s.Length-1]];
        for(var i=s.Length-2;i>=0;i--) {
            var mi = map[s[i]];
            if (mi<map[s[i+1]]) {
                result -= mi;
            }
            else {
                result += mi;
            }
        }
        return result;
    }
}
