// Copyright (c) 2024 Alexey Filatov
// 682 - Baseball Game (https://leetcode.com/problems/baseball-game)
// Date solved: 12/17/2024 10:46:19 PM +00:00
// Memory: 41.4 MB
// Runtime: 2 ms


public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new int[operations.Length];
        var i = 0;
        foreach(var op in operations) {
            switch(op) {
                case "C":
                    i--;
                    break;
                case "D":
                    stack[i] = stack[i-1]*2;
                    i++;
                    break;
                case "+":
                    stack[i] = stack[i-1]+stack[i-2];
                    i++;
                    break;
                default:
                    stack[i] = int.Parse(op);
                    i++;
                    break;
            }
        }
        var s = 0;
        for(var j=0; j<i; j++) {
            s += stack[j];
        }
        return s;
    }
}
