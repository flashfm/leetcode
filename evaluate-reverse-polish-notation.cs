// Evaluate Reverse Polish Notation
// https://leetcode.com/problems/evaluate-reverse-polish-notation
// Date solved: 01/16/2020 09:38:46 +00:00

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
