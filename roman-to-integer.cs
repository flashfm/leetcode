// Roman to Integer
// https://leetcode.com/problems/roman-to-integer
// Date solved: 03/18/2020 05:49:11 +00:00

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
