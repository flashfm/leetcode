// Copyright (c) 2020 Alexey Filatov
// 326 - Power of Three (https://leetcode.com/problems/power-of-three)
// Date solved: 3/17/2020 4:56:56 AM +00:00
// Memory: 16.6 MB
// Runtime: 76 ms


public class Solution {
    public bool IsPowerOfThree(int n) {
        return n<1 ? false : 1162261467 % n == 0;
    }
}
