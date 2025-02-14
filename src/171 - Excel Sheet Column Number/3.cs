// Copyright (c) 2020 Alexey Filatov
// 171 - Excel Sheet Column Number (https://leetcode.com/problems/excel-sheet-column-number)
// Date solved: 8/11/2020 5:02:54 AM +00:00
// Memory: 24.4 MB
// Runtime: 76 ms


public class Solution {
    public int TitleToNumber(string s) {
        int result = 0;
        foreach(var c in s) {
            result = result * 26 + (c - 'A') + 1;
        }
        return result;
    }
}
