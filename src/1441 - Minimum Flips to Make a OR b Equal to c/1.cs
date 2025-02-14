// Copyright (c) 2024 Alexey Filatov
// 1441 - Minimum Flips to Make a OR b Equal to c (https://leetcode.com/problems/minimum-flips-to-make-a-or-b-equal-to-c)
// Date solved: 11/24/2024 7:56:12 AM +00:00
// Memory: 26.8 MB
// Runtime: 20 ms


public class Solution {
    public int MinFlips(int a, int b, int c) {
        var result = 0;
        for(var i = 0; i<32; i++) {
            if ((c&1)==0) {
                if ((a&1)==1) {
                    result++;
                }
                if ((b&1)==1) {
                    result++;
                }
            }
            else if ((a&1)==0 && (b&1)==0) {
                result++;
            }
            a = a>>1;
            b = b>>1;
            c = c>>1;
        }
        return result;
    }
}
