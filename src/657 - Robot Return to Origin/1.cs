// Copyright (c) 2024 Alexey Filatov
// 657 - Robot Return to Origin (https://leetcode.com/problems/robot-return-to-origin)
// Date solved: 12/18/2024 12:07:57 AM +00:00
// Memory: 43.9 MB
// Runtime: 3 ms


public class Solution {
    public bool JudgeCircle(string moves) {
        var x = 0;
        var y = 0;
        foreach(var m in moves) {
            switch(m) {
                case 'R':
                    x++;
                    break;
                case 'L':
                    x--;
                    break;
                case 'U':
                    y--;
                    break;
                case 'D':
                    y++;
                    break;
            }
        }
        return x==0 && y==0;
    }
}
