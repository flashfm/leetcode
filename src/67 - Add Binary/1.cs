// Copyright (c) 2020 Alexey Filatov
// 67 - Add Binary (https://leetcode.com/problems/add-binary)
// Date solved: 7/19/2020 10:32:54 AM +00:00
// Memory: 24.5 MB
// Runtime: 108 ms


public class Solution {
    public string AddBinary(string a, string b) {        
        var i = 0;
        var result = new List<char>();
        var over = false;
        while(i<a.Length || i<b.Length) {
            var x = i<a.Length ? a[a.Length-1-i] : '0';
            var y = i<b.Length ? b[b.Length-1-i] : '0';
            var nextOver = false;
            char r;
            if (x=='1' && y=='1') {
                r = '0';
                nextOver = true;
            }
            else if (x=='1' || y=='1') {
                r = '1';
            }
            else {
                r = '0';
            }
            if (over) {
                if (r=='1') {
                    nextOver = true;
                }
                r = r=='0' ? '1' : '0';
            }
            result.Add(r);
            over = nextOver;
            i++;
        }
        if (over) {
            result.Add('1');
        }
        result.Reverse();
        return new string(result.ToArray());
    }
}
