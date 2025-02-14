// Copyright (c) 2020 Alexey Filatov
// 342 - Power of Four (https://leetcode.com/problems/power-of-four)
// Date solved: 8/5/2020 6:14:49 AM +00:00
// Memory: 14.7 MB
// Runtime: 44 ms


public class Solution {
    public bool IsPowerOfFour(int num) {
        // 4=100 - 2zeros
        // 16=10000 - 4zeros
        // 64=1000000 -8zeros
        long x = 1;
        while (x<int.MaxValue) {
            if (num==x) return true;
            x = x << 2;
        }
        return false;
    }
}
