// Copyright (c) 2024 Alexey Filatov
// 400 - Nth Digit (https://leetcode.com/problems/nth-digit)
// Date solved: 11/8/2024 6:41:32 AM +00:00
// Memory: 27.3 MB
// Runtime: 0 ms


public class Solution {
    public int FindNthDigit(int n) {
        var i = 1;
        long blockLen = 0;
        while(true) {
            blockLen = 9 * i * (long)Math.Pow(10, i-1);
            if (n<=blockLen) {
                break;
            }
            n -= (int)blockLen;
            i++;
        }
        n--;
        long num = (long)Math.Pow(10, i-1) + n/i;
        var digit = n%i;
        return num.ToString()[digit]-'0';
    }
}
