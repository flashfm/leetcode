// Copyright (c) 2020 Alexey Filatov
// 502 - IPO (https://leetcode.com/problems/ipo)
// Date solved: 3/19/2020 9:21:16 PM +00:00
// Memory: 35.6 MB
// Runtime: 2708 ms


public class Solution {
    public class Project {
        public int Profit;
        public int Cap;
    }
    public int FindMaximizedCapital(int k, int W, int[] Profits, int[] Capital) {
        var set = new List<Project>();
        for(var i = 0; i<Profits.Length;i++) {
            set.Add(new Project { Profit = Profits[i], Cap = Capital[i] });
        }
        set = set.OrderByDescending(s => s.Profit).ToList();
        var used = new HashSet<Project>();
        
        for(var i=0;i<k;i++) {

            var best = set.Where(s => s.Cap<=W).FirstOrDefault();
            if (best==null) break;
            
            set.Remove(best);
            //used.Add(best);
            W += best.Profit;
        }
        
        return W;
    }
}
