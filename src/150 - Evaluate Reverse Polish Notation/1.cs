// Copyright (c) 2020 Alexey Filatov
// 150 - Evaluate Reverse Polish Notation (https://leetcode.com/problems/evaluate-reverse-polish-notation)
// Date solved: 1/16/2020 9:17:56 AM +00:00
// Memory: 26.1 MB
// Runtime: 432 ms


public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens.Length==0) return 0;
        return EvalRPNList(new List<string>(tokens));
    }
    
    private int EvalRPNList(List<string> tokens)
    {
        while(tokens.Count>1) {
            for(var i=0;i<tokens.Count;i++) {
                var t = tokens[i];
                var op1 = 0;
                var op2 = 0;
                var ex = false;
                if (t=="+" || t=="-" || t=="/" || t=="*") {
                    op1 = int.Parse(tokens[i-2]);
                    op2 = int.Parse(tokens[i-1]);
                    ex = true;
                }

                switch(t) {
                    case "+":
                        Replace(tokens, i, op1+op2);
                        break;
                    case "-":
                        Replace(tokens, i, op1-op2);
                        break;
                    case "*":
                        Replace(tokens, i, op1*op2);
                        break;
                    case "/":
                        Replace(tokens, i, op1/op2);
                        break;
                }

                if (ex) {
                    i -= 2;
                }
            }
        }
        
        return int.Parse(tokens[0]);
    }
    
    private void Replace(List<string> tokens, int pos, int val)
    {
        var i = pos - 2;
        tokens.RemoveAt(i);
        tokens.RemoveAt(i);
        tokens.RemoveAt(i);
        tokens.Insert(i, val.ToString());
    }
}
