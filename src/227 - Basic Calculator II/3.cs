// Copyright (c) 2022 Alexey Filatov
// 227 - Basic Calculator II (https://leetcode.com/problems/basic-calculator-ii)
// Date solved: 11/10/2022 7:37:34 AM +00:00
// Memory: 46 MB
// Runtime: 231 ms


public class Solution {
    public int Calculate(string s) {
        var adds = s.Split('+');
        return adds.Select(a => Minus(a)).Sum();
    }
    private int Minus(ReadOnlySpan<char> s)
    {
        var start = 0;
        var x = 1;
        var result = 0;
        for(var i = 0; i<s.Length; i++) {
            var c = s[i];
            if (c=='-') {
                result += x * MulOrDiv(s.Slice(start, i - start));
                x = -1;
                start = i+1;
            }
        }
        if (start!=s.Length) {
            result += x * MulOrDiv(s.Slice(start));
        }

        return result;
    }
    private int MulOrDiv(ReadOnlySpan<char> s)
    {
        Console.WriteLine(">"+s.ToString());
        var result = 1;
        bool devide = false;
        var curNum = 0;
        var hasNum = false;
        for(var i = 0; i<s.Length; i++) {
            var c = s[i];
            if (c==' ') continue;
            if (c=='*' || c=='/') {
                result = devide ? result / curNum : result * curNum;
            }
            if (c=='*') {                
                curNum = 0;
                hasNum = false;
                devide = false;
            }
            else if (c=='/') {
                curNum = 0;
                hasNum = false;
                devide = true;
            }
            else {
                hasNum = true;
                curNum = curNum*10 + (c-'0');
            }
        }
        if (hasNum) {
            result = devide ? result / curNum : result * curNum;
        }
        return result;
    }
}
