// Copyright (c) 2024 Alexey Filatov
// 224 - Basic Calculator (https://leetcode.com/problems/basic-calculator)
// Date solved: 9/27/2024 7:24:33 AM +00:00
// Memory: 40.5 MB
// Runtime: 42 ms


public class Solution {
    public int Calculate(string s) {
        var (result, _) = InnerCalculate(s, 0);
        return result;
    }

    private (int, int) InnerCalculate(string s, int start)
    {
        var result = 0;
        var current = 0;
        var sign = 1;
        for(var i=start; i<s.Length; i++) {
            var c = s[i];
            switch(c) {
                case ' ':
                    break;
                case '+':
                    result += sign * current;
                    sign = 1;
                    current = 0;                 
                    break;
                case '-':
                    result += sign * current;
                    sign = -1;
                    current = 0;
                    break;
                case '(':
                    var inner = 0;
                    (inner, i) = InnerCalculate(s, i+1);
                    result += sign * inner;
                    break;
                case ')':
                    result += sign * current;
                    return (result, i);
                    break;
                default:
                    current = current*10 + (c - '0');
                    break;
            }
        }
        result += sign * current;
        return (result, 0);        
    }
}
