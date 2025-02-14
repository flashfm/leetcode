// Copyright (c) 2024 Alexey Filatov
// 740 - Delete and Earn (https://leetcode.com/problems/delete-and-earn)
// Date solved: 12/19/2024 3:17:12 AM +00:00
// Memory: 45.4 MB
// Runtime: 4 ms


public class Solution {
    public int DeleteAndEarn(int[] nums) {
        var n = 10001;
        var dict = new int[n];
        foreach(var num in nums) {
            dict[num] += num;
        }
        var p2 = dict[0]; // i-2
        var p1 = dict[1]; // i-1
        for(var i=2; i<n; i++) {
            (p1, p2) = (Math.Max(p1, dict[i] + p2), p1);
        }
        return p1;
    }
}
