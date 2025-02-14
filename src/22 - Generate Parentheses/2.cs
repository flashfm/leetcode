// Copyright (c) 2020 Alexey Filatov
// 22 - Generate Parentheses (https://leetcode.com/problems/generate-parentheses)
// Date solved: 1/7/2020 10:10:55 AM +00:00
// Memory: 32.9 MB
// Runtime: 240 ms


public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var results = new List<string>();
        var c = new char[n*2];
        //Gen(c, 0, results, 0, 0);
        Gen2(c, results);
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
    
    private void Gen2(char[] c, List<string> results)
    {
        var i = 0;
        var open = 0;
        var closed = 0;
        while(i!=-1) {
            var forward = false;            
            if (c[i]==0 && open<c.Length/2) {
                c[i] = '(';
                open++;
                forward = true;
            }
            else if ((c[i]==0 && open>closed) || (c[i]=='(' && open>closed+1)) {
                if (c[i]=='(') open--;
                c[i] = ')';
                closed++;
                forward = true;
            }

            if (forward) {
                if (i==c.Length-1) {
                    results.Add(new string(c));
                }
                else {
                    i++;
                }
            }
            else {
                if (c[i]==')') closed--;
                if (c[i]=='(') open--;
                c[i] = (char)0;
                i--;
            }
        }
    }
}
