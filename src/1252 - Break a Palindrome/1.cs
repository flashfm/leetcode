// Copyright (c) 2022 Alexey Filatov
// 1252 - Break a Palindrome (https://leetcode.com/problems/break-a-palindrome)
// Date solved: 10/11/2022 2:45:50 AM +00:00
// Memory: 36.9 MB
// Runtime: 80 ms


public class Solution {
    public string BreakPalindrome(string palindrome) {
        // go from the beginning to n/2 (even if odd) and try to "decrease" a letter
        var n = palindrome.Length;
        var arr = palindrome.ToArray();
        for(var i = 0; i<n/2; i++) {
            if (arr[i]!='a') {
                arr[i]='a';
                return new string(arr);
            }
        }
        for(var i = n-1; i>n/2-(n%2==0 ? 1 : 0); i--) {
            if (arr[i]!='z') {
                arr[i]++;
                return new string(arr);
            }
        }
        return "";
    }
}
