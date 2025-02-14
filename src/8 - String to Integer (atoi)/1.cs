// Copyright (c) 2020 Alexey Filatov
// 8 - String to Integer (atoi) (https://leetcode.com/problems/string-to-integer-atoi)
// Date solved: 3/20/2020 4:51:53 AM +00:00
// Memory: 24.9 MB
// Runtime: 76 ms


public class Solution {
    public int MyAtoi(string str) {
        if (str==null || str.Length==0) return 0;
        var i = 0;
        while (i<str.Length && str[i]==' ') i++;
        if (i>=str.Length) return 0;
        var minus = false;
        if (str[i]=='-') {
            minus = true;
            i++;
        }
        else if (str[i]=='+') {
            i++;
        }
        var result = 0;
        while(i<str.Length && IsDigit(str[i])) {
            var d = str[i]-'0';
            if (result>(int.MaxValue-d)/10) return minus ? int.MinValue : int.MaxValue;
            result = result * 10 + d;
            i++;
        }
        if (minus) result *= -1;
        return result;
    }
    private bool IsDigit(char c)
    {
        return c >= '0' && c<='9';
    }
}
