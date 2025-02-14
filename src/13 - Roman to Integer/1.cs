// Copyright (c) 2020 Alexey Filatov
// 13 - Roman to Integer (https://leetcode.com/problems/roman-to-integer)
// Date solved: 3/18/2020 5:35:46 AM +00:00
// Memory: 25.9 MB
// Runtime: 112 ms


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
        var map2 = new Dictionary<string, int> {
            {"IV", 4}  ,
            {"IX", 9} , 
            {"XL", 40}  ,
            {"XC", 90}  ,
            {"CD", 400}  ,
            {"CM", 900}  
        };
        var result = 0;
        for(var i=0;i<s.Length;i++) {
            var s2 = i<s.Length-1 ? s.Substring(i,2) : null;
            if (s2!=null && map2.TryGetValue(s2, out var val)) {
                i++;
                result += val;
            }
            else {
                result += map[s[i]];
            }
        }
        return result;
    }
}
