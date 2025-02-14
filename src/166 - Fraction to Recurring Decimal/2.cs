// Copyright (c) 2020 Alexey Filatov
// 166 - Fraction to Recurring Decimal (https://leetcode.com/problems/fraction-to-recurring-decimal)
// Date solved: 1/28/2020 6:44:22 AM +00:00
// Memory: 24.2 MB
// Runtime: 80 ms


public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        var result = (numerator<0 && denominator>0) || (numerator>0 && denominator<0) ? "-" : "";
        var n = Math.Abs((long)numerator);
        var d = Math.Abs((long)denominator);
        var x = n / d;
        var rem = n % d;
        result += x;
        if (rem>0) {
            result += "." + RemToString(rem * 10, d);
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
