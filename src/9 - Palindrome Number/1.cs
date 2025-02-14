// Copyright (c) 2024 Alexey Filatov
// 9 - Palindrome Number (https://leetcode.com/problems/palindrome-number)
// Date solved: 10/15/2024 2:10:19 AM +00:00
// Memory: 31.9 MB
// Runtime: 46 ms


public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) {
            return false;
        }
        var b = (int)Math.Pow(10, (int)Math.Log10(x));
        while(x>0) {
            var d1 = x/b;
            var d2 = x%10;
            //Console.WriteLine($"{x}, {d1}, {d2}");
            if (d1!=d2) {
                return false;
            }
            x -= b * d1;
            x /= 10;
            b /= 100;
        }
        return true;
    }
}
