// Copyright (c) 2024 Alexey Filatov
// 735 - Asteroid Collision (https://leetcode.com/problems/asteroid-collision)
// Date solved: 11/11/2024 9:39:31 PM +00:00
// Memory: 49.3 MB
// Runtime: 6 ms


public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        foreach(var a in asteroids) {
            if (a>0) {
                stack.Push(a);
            }
            else {
                while (stack.Count>0 && stack.Peek()>0 && stack.Peek()<-a) {
                    stack.Pop();
                }
                if (stack.Count>0 && stack.Peek()>0 && stack.Peek()==-a) {
                    stack.Pop();
                    continue;
                }
                if (stack.Count==0 || stack.Peek()<0) {
                    stack.Push(a);
                }
            }
        }
        return stack.Reverse().ToArray();
    }
}
