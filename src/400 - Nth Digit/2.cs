// Copyright (c) 2024 Alexey Filatov
// 400 - Nth Digit (https://leetcode.com/problems/nth-digit)
// Date solved: 11/8/2024 6:43:15 AM +00:00
// Memory: 26.9 MB
// Runtime: 0 ms


public class Solution {
    public int FindNthDigit(int n) {
        var i = 1;
        long blockLen = 0;
        long z = 1;
        while(true) {
            blockLen = 9 * i * z;
            if (n<=blockLen) {
                break;
            }
            n -= (int)blockLen;
            i++;
            z *= 10;
        }
        n--;
        var num = z + n/i;
        var digit = n%i;
        return num.ToString()[digit]-'0';
    }
}
