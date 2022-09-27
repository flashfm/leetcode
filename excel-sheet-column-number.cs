// Excel Sheet Column Number
// https://leetcode.com/problems/excel-sheet-column-number
// Date solved: 12/30/2019 09:59:57 +00:00

public class Solution {
    public int TitleToNumber(string s) {
        var result = 0;
        var b = 1;
        for(var i=0;i<s.Length;i++) {
            var c = s[s.Length-1-i];
            var d = (c - 'A') + 1;
            result += d * b;
            b *= 26;
        }
        return result;
    }
}
