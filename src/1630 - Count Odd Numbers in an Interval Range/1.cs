// Copyright (c) 2024 Alexey Filatov
// 1630 - Count Odd Numbers in an Interval Range (https://leetcode.com/problems/count-odd-numbers-in-an-interval-range)
// Date solved: 12/18/2024 2:48:54 AM +00:00
// Memory: 27.4 MB
// Runtime: 19 ms


public class Solution {
    public int CountOdds(int low, int high) {
        if (low%2==0) {
            low++;
        }
        if (high%2==0) {
            high--;
        }
        return (high-low)/2 + 1;
    }
}
