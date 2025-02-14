// Copyright (c) 2024 Alexey Filatov
// 1833 - Find the Highest Altitude (https://leetcode.com/problems/find-the-highest-altitude)
// Date solved: 11/10/2024 4:28:30 AM +00:00
// Memory: 40.2 MB
// Runtime: 0 ms


public class Solution {
    public int LargestAltitude(int[] gain) {
        var sum = 0;
        var max = 0;
        foreach(var g in gain) {
            sum += g;
            max = Math.Max(max, sum);
        }
        return max;
    }
}
