// Plus One
// https://leetcode.com/problems/plus-one
// Date solved: 03/21/2020 06:03:48 +00:00

public class Solution {
    public int[] PlusOne(int[] digits) {
        var over = true;
        var result = new int[digits.Length];
        for(var i = digits.Length-1; i>=0; i--) {
            var nd = digits[i];
            if (over) nd++;
            over = nd==10;
            result[i] = over ? 0 : nd;
        }
        if (over) {
            result = new int[digits.Length+1];
            result[0] = 1;
        }
        return result;
    }
}
