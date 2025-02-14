// Copyright (c) 2024 Alexey Filatov
// 649 - Dota2 Senate (https://leetcode.com/problems/dota2-senate)
// Date solved: 11/14/2024 7:24:48 AM +00:00
// Memory: 42.4 MB
// Runtime: 5 ms


public class Solution {
    public string PredictPartyVictory(string senate) {
        var n = senate.Length;
        var rs = new Queue<int>();
        var ds = new Queue<int>();
        var dead = new bool[n];
        for(var i=0; i<n; i++) {
            var q = senate[i]=='R' ? rs : ds;
            q.Enqueue(i);
        }
        // Console.WriteLine(string.Join(",", rs));
        // Console.WriteLine(string.Join(",", ds));
        var j = 0;
        while(rs.Count>0 && ds.Count>0) {
            if (!dead[j]) {
                var q = senate[j]=='R' ? rs : ds;
                q.Enqueue(q.Dequeue());
                var aq = senate[j]=='R' ? ds : rs;
                var k = aq.Dequeue();
                dead[k] = true;
            }
            j++;
            if (j==n) {
                j = 0;
            }
        }
        return rs.Count>0 ? "Radiant" : "Dire";
    }
}
