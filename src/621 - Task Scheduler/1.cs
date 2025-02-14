// Copyright (c) 2020 Alexey Filatov
// 621 - Task Scheduler (https://leetcode.com/problems/task-scheduler)
// Date solved: 1/6/2020 2:36:37 AM +00:00
// Memory: 44.2 MB
// Runtime: 2636 ms


public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var groups = new Dictionary<int, int>();
        foreach(var c in tasks) {
            var key = c-'A';
            groups.TryGetValue(key, out var count);
            groups[key] = count+1;
        }
        var sortedGroups = SortGroups(groups);
        var list = new List<int>();
            
        while(groups.Count>0) {
            var added = false;
            for(var groupIndex=0;groupIndex<sortedGroups.Count;groupIndex++) {
                var group = sortedGroups[groupIndex];
                if (CanAdd(group, list, n)) {
                    list.Add(group);
                    
                    groups.TryGetValue(group, out var count);
                    count--;
                    if (count==0) {
                        groups.Remove(group);
                    }
                    else {
                        groups[group] = count;
                    }
                    
                    sortedGroups = SortGroups(groups);
                    
                    added = true;
                    break;
                }
            }
            if (!added) {
                list.Add(-1);
            }
        }
        return list.Count;
    }
    
    private List<int> SortGroups(Dictionary<int, int> groups)
    {
        return groups.OrderByDescending(g => g.Value).Select(g => g.Key).ToList();
    }
     
    private bool CanAdd(int group, List<int> list, int n)
    {
        for(var i=0;i<n;i++) {
            var j = list.Count-1-i;
            if (j<0) break;
            if (list[j]==group) return false;
        }
        return true;
    }
}
