// Copyright (c) 2020 Alexey Filatov
// 66 - Plus One (https://leetcode.com/problems/plus-one)
// Date solved: 3/21/2020 6:00:02 AM +00:00
// Memory: 30 MB
// Runtime: 240 ms


public class Solution {
    public int[] PlusOne(int[] digits) {
        
        if (digits.All(d => d==9)) {
            var arr = new int[digits.Length+1];
            arr[0] = 1;
            return arr;
        }
        
        var over = true;
        var result = new int[digits.Length];
        for(var i = digits.Length-1; i>=0; i--) {
            var nd = digits[i];
            if (over) nd++;
            over = nd==10;
            if (over) nd = 0;
            result[i]= nd;
        }
        return result;
    }
}
