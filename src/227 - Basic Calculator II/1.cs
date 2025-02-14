// Copyright (c) 2022 Alexey Filatov
// 227 - Basic Calculator II (https://leetcode.com/problems/basic-calculator-ii)
// Date solved: 11/10/2022 7:18:08 AM +00:00
// Memory: 46.8 MB
// Runtime: 118 ms


public class Solution {
    public int Calculate(string s) {
        var adds = s.Split('+');
        return adds.Select(a => Minus(a)).Sum();
    }
    private int Minus(string s)
    {
        var subs = s.Split('-');
        var result = MulOrDiv(subs[0]);
        for(var i = 1; i<subs.Length; i++) {
            result -= MulOrDiv(subs[i]);
        }
        return result;
    }
    private int MulOrDiv(string s)
    {
        var result = 1;
        bool devide = false;
        var curNum = new StringBuilder();
        for(var i = 0; i<s.Length; i++) {
            var c = s[i];
            if (c=='*') {                
                result = Apply(result, curNum, devide);
                devide = false;
            }
            else if (c=='/') {
                result = Apply(result, curNum, devide);
                devide = true;
            }
            else {
                curNum.Append(c);
            }
        }
        if (curNum.Length>0) {
            result = Apply(result, curNum, devide);
        }
        return result;
    }
    private int Apply(int result, StringBuilder curNumString, bool devide)
    {
        var curNum =  int.Parse(curNumString.ToString());
        curNumString.Clear();
        return devide ? result / curNum : result * curNum;
    }    
}
