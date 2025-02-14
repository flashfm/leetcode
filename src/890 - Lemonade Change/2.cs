// Copyright (c) 2024 Alexey Filatov
// 890 - Lemonade Change (https://leetcode.com/problems/lemonade-change)
// Date solved: 12/18/2024 3:27:54 AM +00:00
// Memory: 58 MB
// Runtime: 1 ms


public class Solution {
    public bool LemonadeChange(int[] bills) {
        var b5 = 0;
        var b10 = 0;
        foreach(var b in bills) {
            if (b==5) {
                b5++;
            }
            else if (b==10) {
                b5--;
                b10++;
            }
            else if (b10>0) { // 15 = 10+5 or 3*5
                b10--;
                b5--;
            }
            else {
                b5 -= 3;
            }
            if (b5<0) {
                return false;
            }
        }
        return true;
    }
}
