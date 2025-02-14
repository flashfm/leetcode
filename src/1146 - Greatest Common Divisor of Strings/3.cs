// Copyright (c) 2024 Alexey Filatov
// 1146 - Greatest Common Divisor of Strings (https://leetcode.com/problems/greatest-common-divisor-of-strings)
// Date solved: 11/8/2024 9:42:10 PM +00:00
// Memory: 40.6 MB
// Runtime: 0 ms


public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        var n1 = str1.Length;
        var n2 = str2.Length;
        if (n1>n2) {
            return GcdOfStrings(str2, str1);
        }
        var xlen = Gcd(n2, n1);
        var pref = str1.Substring(0, xlen);
        for(var i = 0; i<n1/xlen; i++) {
            if (string.Compare(pref, 0, str1, i * xlen, xlen)!=0) {
                return "";
            }
        }
        for(var i = 0; i<n2/xlen; i++) {
            if (string.Compare(pref, 0, str2, i * xlen, xlen)!=0) {
                return "";
            }
        }
        return pref;
    }

    private int Gcd(int a, int b)
        => b==0 ? a : Gcd(b, a%b);
}
