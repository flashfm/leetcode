// Copyright (c) 2024 Alexey Filatov
// 649 - Dota2 Senate (https://leetcode.com/problems/dota2-senate)
// Date solved: 11/14/2024 7:30:06 AM +00:00
// Memory: 41.8 MB
// Runtime: 4 ms


public class Solution {
    public string PredictPartyVictory(string senate) {
        var n = senate.Length;
        var rs = new Queue<int>();
        var ds = new Queue<int>();
        var dead = new bool[n];
        for(var i=0; i<n; i++) {
            (senate[i]=='R' ? rs : ds).Enqueue(i);
        }
        while(rs.Count>0 && ds.Count>0) {
            var q = rs.Peek()<ds.Peek() ? rs : ds;
            var aq = rs.Peek()<ds.Peek() ? ds : rs;
            q.Enqueue(n+q.Dequeue());
            aq.Dequeue();
        }
        return rs.Count>0 ? "Radiant" : "Dire";
    }
}
