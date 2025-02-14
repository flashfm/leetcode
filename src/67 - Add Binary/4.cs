// Copyright (c) 2020 Alexey Filatov
// 67 - Add Binary (https://leetcode.com/problems/add-binary)
// Date solved: 7/19/2020 10:40:45 AM +00:00
// Memory: 24.5 MB
// Runtime: 88 ms


public class Solution {
    public string AddBinary(string a, string b) {        
        var i = 0;
        var result = new List<char>();
        var over = false;
        while(i<a.Length || i<b.Length) {
            var x = i<a.Length ? a[a.Length-1-i]=='1' : false;
            var y = i<b.Length ? b[b.Length-1-i]=='1' : false;
            result.Add((x^y^over) ? '1' : '0');
            over = x && y || (over && (x || y));
            i++;
        }
        if (over) {
            result.Add('1');
        }
        result.Reverse();
        return new string(result.ToArray());
    }
}
