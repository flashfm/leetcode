// Copyright (c) 2024 Alexey Filatov
// 682 - Baseball Game (https://leetcode.com/problems/baseball-game)
// Date solved: 12/17/2024 10:41:45 PM +00:00
// Memory: 41.5 MB
// Runtime: 6 ms


public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        foreach(var op in operations) {
            switch(op) {
                case "C":
                    stack.Pop();
                    break;
                case "D":
                    stack.Push(stack.Peek()*2);
                    break;
                case "+":
                    var x = stack.Pop();
                    var y = stack.Peek();
                    stack.Push(x);
                    stack.Push(x+y);
                    break;
                default:
                    stack.Push(int.Parse(op));
                    break;
            }
        }
        return stack.Sum();
    }
}
