// Copyright (c) 2020 Alexey Filatov
// 150 - Evaluate Reverse Polish Notation (https://leetcode.com/problems/evaluate-reverse-polish-notation)
// Date solved: 1/16/2020 9:32:04 AM +00:00
// Memory: 26.1 MB
// Runtime: 120 ms


public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens.Length==0) return 0;
        eval(tokens, tokens.Length-1, out var result, out var s);
        return result;
    }
    
    private void eval(string[] tokens, int start, out int result, out int newStart)
    {
        result = 0;
        var t = tokens[start];
        if (int.TryParse(t, out var r)) {
            result = r;
            newStart = start;
        }
        else {
            eval(tokens, start-1, out var op2, out var op2start);
            eval(tokens, op2start-1, out var op1, out var op1start);
            newStart = op1start;            
                switch(t) {
                    case "+":
                        result = op1+op2;
                        break;
                    case "-":
                        result = op1-op2;
                        break;
                    case "*":
                        result = op1*op2;
                        break;
                    case "/":
                        result = op1/op2;
                        break;
                }
        }
        
    }
}
