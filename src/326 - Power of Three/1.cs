// Copyright (c) 2020 Alexey Filatov
// 326 - Power of Three (https://leetcode.com/problems/power-of-three)
// Date solved: 3/17/2020 4:38:41 AM +00:00
// Memory: 16.6 MB
// Runtime: 84 ms


public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n<=0) return false;
        while(n>1) {
            if (n % 3 !=0 ) return false;
            n /= 3;
        }
        return true;
    }
}
