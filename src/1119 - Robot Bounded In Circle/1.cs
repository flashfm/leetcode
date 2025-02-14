// Copyright (c) 2024 Alexey Filatov
// 1119 - Robot Bounded In Circle (https://leetcode.com/problems/robot-bounded-in-circle)
// Date solved: 12/18/2024 2:18:10 AM +00:00
// Memory: 40.4 MB
// Runtime: 0 ms


public class Solution {
    public bool IsRobotBounded(string instructions) {
        var x = 0;
        var y = 0;
        var dx = 0;
        var dy = -1;
        for(var j=0; j<4; j++) {
            foreach(var i in instructions) {
                switch(i) {
                    case 'G':
                        x += dx;
                        y += dy;
                        break;
                    case 'L':
                        (dx, dy) = (dx!=0 ? 0 : (dy==-1 ? -1 : 1), dy!=0 ? 0 : (dx==-1 ? 1 : -1));
                        break;
                    case 'R':
                        (dx, dy) = (dx!=0 ? 0 : (dy==-1 ? 1 : -1), dy!=0 ? 0 : (dx==-1 ? -1 : 1));
                        break;
                }
            }
            if (x==0 && y==0) {
                return true;
            }
        }
        return false;
    }
}
