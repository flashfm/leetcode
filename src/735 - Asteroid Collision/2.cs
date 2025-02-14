// Copyright (c) 2024 Alexey Filatov
// 735 - Asteroid Collision (https://leetcode.com/problems/asteroid-collision)
// Date solved: 11/12/2024 12:29:24 AM +00:00
// Memory: 49.4 MB
// Runtime: 4 ms


public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        foreach(var a in asteroids) {
            if (a>0) {
                stack.Push(a);
            }
            else {
                var destroyed = false;
                while (stack.Count>0 && stack.Peek()>0 && stack.Peek()<=-a) {
                    if (stack.Pop()==-a) {
                        destroyed = true;
                        break;
                    }
                }
                if (!destroyed && (stack.Count==0 || stack.Peek()<0)) {
                    stack.Push(a);
                }
            }
        }
        return stack.Reverse().ToArray();
    }
}
