// Copyright (c) 2020 Alexey Filatov
// 150 - Evaluate Reverse Polish Notation (https://leetcode.com/problems/evaluate-reverse-polish-notation)
// Date solved: 1/16/2020 9:38:46 AM +00:00
// Memory: 25.7 MB
// Runtime: 96 ms


public class Solution {
    public int EvalRPN(string[] tokens) {
        var s = new Stack<int>();
        foreach(var t in tokens) {
            if (t=="+") {
                s.Push(s.Pop()+s.Pop());
            }
            else if (t=="-") {
                var a = s.Pop();
                var b = s.Pop();
                s.Push(b-a);
            }
            else if (t=="*") {
                s.Push(s.Pop()*s.Pop());
            }
            else if (t=="/") {
                var a = s.Pop();
                var b = s.Pop();
                s.Push(b / a);
            }
            else {
                s.Push(int.Parse(t));
            }
        }
        return s.Pop();
    }
}
