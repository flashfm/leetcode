// Copyright (c) 2020 Alexey Filatov
// 66 - Plus One (https://leetcode.com/problems/plus-one)
// Date solved: 3/21/2020 6:01:44 AM +00:00
// Memory: 29.8 MB
// Runtime: 248 ms


public class Solution {
    public int[] PlusOne(int[] digits) {
        var over = true;
        var result = new int[digits.Length];
        for(var i = digits.Length-1; i>=0; i--) {
            var nd = digits[i];
            if (over) nd++;
            over = nd==10;
            if (over) nd = 0;
            result[i] = nd;
        }
        if (over) {
            result = new int[digits.Length+1];
            result[0] = 1;
        }
        return result;
    }
}
