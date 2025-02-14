// Copyright (c) 2020 Alexey Filatov
// 326 - Power of Three (https://leetcode.com/problems/power-of-three)
// Date solved: 3/17/2020 4:56:15 AM +00:00
// Memory: 16.6 MB
// Runtime: 80 ms


public class Solution {
    public bool IsPowerOfThree(int n) {
        var c = 1162261467;
        return n>=1 && c % n == 0 ? true : false;
    }
}
