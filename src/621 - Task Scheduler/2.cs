// Copyright (c) 2020 Alexey Filatov
// 621 - Task Scheduler (https://leetcode.com/problems/task-scheduler)
// Date solved: 1/6/2020 6:24:46 AM +00:00
// Memory: 34.9 MB
// Runtime: 212 ms


public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var groups = new int[26];
        foreach(var c in tasks) {
            groups[c-'A']++;
        }    
        Array.Sort(groups);
        var result = 0;
            
        while(groups[25]>0) {
            
            var i = 0;
            while(i<=n) {
                if (groups[25]==0) break;
                
                if (25-i>=0 && groups[25-i]>0) groups[25-i]--;
                
                result++;
                i++;                
            }
            
            Array.Sort(groups);
        }

        return result;
    }
}
