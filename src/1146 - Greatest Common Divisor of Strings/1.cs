// Copyright (c) 2024 Alexey Filatov
// 1146 - Greatest Common Divisor of Strings (https://leetcode.com/problems/greatest-common-divisor-of-strings)
// Date solved: 11/8/2024 9:38:25 PM +00:00
// Memory: 40.2 MB
// Runtime: 1 ms


public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        var n1 = str1.Length;
        var n2 = str2.Length;
        if (n1>n2) {
            return GcdOfStrings(str2, str1);
        }
        var xlen = Gcd(n2, n1);
        var pref = str1.Substring(0, xlen);
        return str1==Mul(pref, n1/xlen) && str2==Mul(pref, n2/xlen) ? pref : "";
    }

    private string Mul(string s, int val)
        => string.Concat(Enumerable.Repeat(s, val));

    private int Gcd(int a, int b)
        => b==0 ? a : Gcd(b, a%b);
}
