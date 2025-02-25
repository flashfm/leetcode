// Copyright (c) 2020 Alexey Filatov
// 875 - Longest Mountain in Array (https://leetcode.com/problems/longest-mountain-in-array)
// Date solved: 11/17/2020 5:04:11 AM +00:00
// Memory: 30.3 MB
// Runtime: 108 ms


public class Solution {
    public int LongestMountain(int[] A) {
        var growth = false;
        var decrease = false;
        var curLen = 0;
        var result = 0;
        for(var i = 1; i<A.Length; i++) {
            if (A[i] > A[i-1]) {
                decrease = false;
                if (!growth) {
                    curLen = 2;
                    growth = true;
                }
                else {
                    curLen++;
                }
            }
            else if (A[i] < A[i-1]) {
                if (growth) {
                    growth = false;
                    decrease = true;
                }
                if (decrease) {
                    curLen++;
                }
                result = Math.Max(result, curLen);
            }
            else {
                growth = false;
                decrease = false;
                curLen = 0;
            }
        }
        return result>=3 ? result : 0;
    }
}
