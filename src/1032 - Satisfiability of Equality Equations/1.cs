// Copyright (c) 2022 Alexey Filatov
// 1032 - Satisfiability of Equality Equations (https://leetcode.com/problems/satisfiability-of-equality-equations)
// Date solved: 9/26/2022 5:13:15 AM +00:00
// Memory: 40.9 MB
// Runtime: 97 ms


public class Solution {
    public bool EquationsPossible(string[] equations) {
        int groupIndex = 1;
        var groupByLetter = new int[26];
        foreach(var eq in equations) {
            if (eq[1]=='!') continue;
            var l1 = eq[0]-'a';
            var l2 = eq[3]-'a';
            var g1 = groupByLetter[l1];
            var g2 = groupByLetter[l2];
            if (g1==0 && g2==0) {
                 groupByLetter[l1] = groupByLetter[l2] = groupIndex++;
            }
            else if (g1==0) {
                groupByLetter[l1] = g2;
            }
            else if (g2==0) {
                groupByLetter[l2] = g1;
            }
            else if (g1!=g2) {
                for(var i=0;i<groupByLetter.Length;i++) {
                    if (groupByLetter[i]==g2) {
                      groupByLetter[i] = g1;   
                    }
                }
            }
        }
        foreach(var eq in equations) {
            if (eq[1]!='!') continue;
            var l1 = eq[0]-'a';
            var l2 = eq[3]-'a';
            if (l1==l2) return false;
            var g1 = groupByLetter[l1];
            var g2 = groupByLetter[l2];
            if (g1==0 && g2==0) continue;
            if (g1==g2) return false;
        }
        return true;
    }
}
