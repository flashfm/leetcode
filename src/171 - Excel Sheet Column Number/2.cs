// Copyright (c) 2020 Alexey Filatov
// 171 - Excel Sheet Column Number (https://leetcode.com/problems/excel-sheet-column-number)
// Date solved: 8/11/2020 5:02:28 AM +00:00
// Memory: 24.3 MB
// Runtime: 76 ms


public class Solution {
    public int TitleToNumber(string s) {
        int result = 0;
        foreach(var c in s) {
            var n = (c - 'A') + 1;
            result *= 26;
            result += n;
        }
        return result;
    }
}
