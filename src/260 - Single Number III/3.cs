// Copyright (c) 2020 Alexey Filatov
// 260 - Single Number III (https://leetcode.com/problems/single-number-iii)
// Date solved: 7/25/2020 6:02:49 AM +00:00
// Memory: 31.5 MB
// Runtime: 448 ms


public class Solution {
    public int[] SingleNumber(int[] nums) {
        if (nums==null || nums.Length==0) return new int[0];
        var x = 0;
        foreach(var n in nums) {
            x ^= n;
        }
        // x = a xor b;
        
        // get last set bit
        x = x & (-x);
        
        var a = 0;
        var b = 0;
        
        foreach(var n in nums) {
            if ((int)(n & x) == 0) {
                // bit not set
                a ^= n; 
            }
            else {
                // bit is set
                b ^= n;
            }
        }
        

        return new[] {a,b};
    }
}
