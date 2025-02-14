// Copyright (c) 2020 Alexey Filatov
// 13 - Roman to Integer (https://leetcode.com/problems/roman-to-integer)
// Date solved: 3/18/2020 5:45:05 AM +00:00
// Memory: 25.6 MB
// Runtime: 92 ms


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
        var result = 0;
        for(var i=0;i<s.Length;i++) {
            var c = s[i];
            var nc = i<s.Length-1 ? s[i+1] : ' ';
            var v = map[c];
            if (
                (c=='I' && (nc=='V' || nc=='X')) ||
                (c=='X' && (nc=='L' || nc=='C')) ||
                (c=='C' && (nc=='D' || nc=='M')) 
            ) {
                i++;
                result += (map[nc] - v);
            }
            else {
                result += v;
            }
        }
        return result;
    }
}
