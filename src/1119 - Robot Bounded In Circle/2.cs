// Copyright (c) 2024 Alexey Filatov
// 1119 - Robot Bounded In Circle (https://leetcode.com/problems/robot-bounded-in-circle)
// Date solved: 12/18/2024 2:23:24 AM +00:00
// Memory: 39.7 MB
// Runtime: 0 ms


public class Solution {
    public bool IsRobotBounded(string instructions) {
        var x = 0;
        var y = 0;
        var directions = new (int X, int Y)[] {
            (0, -1), // dx, dy
            (-1, 0),
            (0, 1),
            (1, 0)
        };
        var dir = 0;
        foreach(var i in instructions) {
            switch(i) {
                case 'G':
                    x += directions[dir].X;
                    y += directions[dir].Y;
                    break;
                case 'L':
                    dir = (dir + 1) % 4;
                    break;
                case 'R':
                    dir = (dir + 3) % 4;
                    break;
            }
        }
        return (x==0 && y==0) || dir>0;
    }
}
