// Copyright (c) 2024 Alexey Filatov
// 13 - Roman to Integer (https://leetcode.com/problems/roman-to-integer)
// Date solved: 10/24/2024 12:10:54 AM +00:00
// Memory: 47.8 MB
// Runtime: 1 ms


public class Solution {
    public int RomanToInt(string s) {
        var result = 0;
        var prev = (char)0;
        for(var i = 0; i<s.Length; i++) {
            switch(s[i]) {
                case 'I':
                    result += 1;
                    break;
                case 'V':
                    result += prev == 'I' ? 3 : 5;
                    break;
                case 'X':
                    result += prev == 'I' ? 8 : 10;
                    break;
                case 'L':
                    result += prev == 'X' ? 30 : 50;
                    break;
                case 'C':
                    result += prev == 'X' ? 80 : 100;
                    break;
                case 'D':
                    result += prev == 'C' ? 300 : 500;
                    break;
                case 'M':
                    result += prev == 'C' ? 800 : 1000;
                    break;
            }
            prev = s[i];
        }
        return result;
    }
}
