// Copyright (c) 2024 Alexey Filatov
// 9 - Palindrome Number (https://leetcode.com/problems/palindrome-number)
// Date solved: 10/15/2024 2:11:31 AM +00:00
// Memory: 31.6 MB
// Runtime: 34 ms


public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) {
            return false;
        }
        var reversed = 0;
        var t = x;
        while(t>0) {
            reversed = reversed * 10 + t%10;
            t /= 10;
        }
        return reversed==x;
    }
}
