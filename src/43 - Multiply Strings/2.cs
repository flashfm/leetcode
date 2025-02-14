// Copyright (c) 2024 Alexey Filatov
// 43 - Multiply Strings (https://leetcode.com/problems/multiply-strings)
// Date solved: 12/18/2024 11:47:57 PM +00:00
// Memory: 43.2 MB
// Runtime: 10 ms


public class Solution {
    public string Multiply(string num1, string num2) {
        var n1 = num1.Length;
        var n2 = num2.Length;
        var mx = new int[n1+n2];
        for(var i=n1-1; i>=0; i--) {
            for(var j=n2-1; j>=0; j--) {
                var m = (num1[i]-'0') * (num2[j]-'0') + mx[i+j+1];
                mx[i+j] += m / 10;
                mx[i+j+1] = m % 10;
            }
        }
        var sb = new StringBuilder();
        foreach(var d in mx) {
            if (d!=0 || sb.Length>0) {
                sb.Append(d);
            }
        }
        return sb.Length==0 ? "0" : sb.ToString();
    }
}
