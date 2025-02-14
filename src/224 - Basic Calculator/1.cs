// Copyright (c) 2024 Alexey Filatov
// 224 - Basic Calculator (https://leetcode.com/problems/basic-calculator)
// Date solved: 9/27/2024 7:17:19 AM +00:00
// Memory: 40.9 MB
// Runtime: 58 ms


public class Solution {
    public int Calculate(string s) {
        var (result, _) = InnerCalculate(s, 0);
        return result;
    }

    private (int, int) InnerCalculate(string s, int start)
    {
        var result = 0;
        var current = 0;
        var sub = false;
        for(var i=start; i<s.Length; i++) {
            var c = s[i];
            switch(c) {
                case ' ':
                    break;
                case '+':
                    result = sub ? result - current : result + current;
                    sub = false;
                    current = 0;                 
                    break;
                case '-':
                    result = sub ? result - current : result + current;
                    sub = true;
                    current = 0;
                    break;
                case '(':
                    var inner = 0;
                    (inner, i) = InnerCalculate(s, i+1);
                    //Console.WriteLine(i);
                    result = sub ? result - inner : result + inner;
                    break;
                case ')':
                    result = sub ? result - current : result + current;
                    return (result, i);
                    break;
                default:
                    current = current*10 + (c - '0');
                    break;
            }
            //Console.WriteLine(current);
        }
        result = sub ? result - current : result + current;
        return (result, 0);        
    }
}
