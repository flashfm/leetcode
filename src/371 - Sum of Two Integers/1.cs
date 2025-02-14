// Copyright (c) 2020 Alexey Filatov
// 371 - Sum of Two Integers (https://leetcode.com/problems/sum-of-two-integers)
// Date solved: 1/16/2020 8:31:31 AM +00:00
// Memory: 14.6 MB
// Runtime: 36 ms


public class Solution {
    public int GetSum(int a, int b) {
        var over = false;
        var result = 0;
        for(var i=0;i<32;i++) {
            var ba = GetBit(a, i);
            var bb = GetBit(b, i);
            var br = (ba == bb && over) || (!over && ba!=bb);
            over = (ba && bb) || (over && (ba || bb));
            if (br) {
                result = SetBit(result, i);
            }
        }
        return result;
    }
    
    private bool GetBit(int a, int number)
    {
        var mask = 1 << number;
        var applied = mask & a;
        return applied != 0;
    }
    
    private int SetBit(int a, int number)
    {
        var mask = 1 << number;
        return a | mask;
    }
}
