// String to Integer (atoi)
// https://leetcode.com/problems/string-to-integer-atoi
// Date solved: 03/20/2020 04:51:53 +00:00

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
