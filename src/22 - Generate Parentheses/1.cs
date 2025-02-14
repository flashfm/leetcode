// Copyright (c) 2020 Alexey Filatov
// 22 - Generate Parentheses (https://leetcode.com/problems/generate-parentheses)
// Date solved: 1/7/2020 9:39:52 AM +00:00
// Memory: 33 MB
// Runtime: 252 ms


public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var results = new List<string>();
        var c = new char[n*2];
        Gen(c, 0, results, 0, 0);
        return results;
    }
    
    private void Gen(char[] c, int i, List<string> results, int open, int closed)
    {        
        if (i==c.Length) {
            results.Add(new string(c));
            return;
        }       
        if (open<c.Length/2) {
            c[i] = '(';
            Gen(c, i+1, results, open+1, closed);
        }
        if (open>closed) {
            c[i] = ')';
            Gen(c, i+1, results, open, closed+1);
        }
    }
}
