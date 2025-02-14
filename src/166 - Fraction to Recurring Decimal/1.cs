// Copyright (c) 2020 Alexey Filatov
// 166 - Fraction to Recurring Decimal (https://leetcode.com/problems/fraction-to-recurring-decimal)
// Date solved: 1/28/2020 6:41:48 AM +00:00
// Memory: 24.1 MB
// Runtime: 72 ms


public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        var minus = (numerator<0 && denominator>0) || (numerator>0 && denominator<0);
        var n = Math.Abs((long)numerator);
        var d = Math.Abs((long)denominator);
        var x = n / d;
        var rem = n % d;
        var result = x.ToString();
        if (rem>0) {
            result += "." + RemToString(rem * 10, d);
        }
        if (minus) {
            result = "-" + result;
        }
        return result;
    }
    
    public string RemToString(long n, long d)
    {
        var s = "";
        var prevNums = new Dictionary<long, int>();
        int i = 0;
        while(n!=0) {
            if (prevNums.ContainsKey(n)) {
                var pos = prevNums[n];
                s = s.Insert(pos, "(");
                return s+")";
            }
            prevNums[n] = i++;
            s += (n/d).ToString();
            n = n%d * 10;
        }
        return s;
    }
}
