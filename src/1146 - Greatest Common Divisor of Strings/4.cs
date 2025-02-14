// Copyright (c) 2024 Alexey Filatov
// 1146 - Greatest Common Divisor of Strings (https://leetcode.com/problems/greatest-common-divisor-of-strings)
// Date solved: 11/8/2024 9:45:14 PM +00:00
// Memory: 40.3 MB
// Runtime: 0 ms


public class Solution {
    public string GcdOfStrings(string str1, string str2)
        => str1+str2 == str2+str1 ? str1.Substring(0, Gcd(str1.Length, str2.Length)) : "";

    private int Gcd(int a, int b)
        => b==0 ? a : Gcd(b, a%b);
}
