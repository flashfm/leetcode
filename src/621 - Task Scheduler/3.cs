// Copyright (c) 2020 Alexey Filatov
// 621 - Task Scheduler (https://leetcode.com/problems/task-scheduler)
// Date solved: 7/30/2020 4:53:14 AM +00:00
// Memory: 34.9 MB
// Runtime: 268 ms


public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if (tasks==null || tasks.Length==0) return 0;
        if (n<=0) return tasks.Length;
        
        var counters = new int[26];
        for(var i = 0; i<tasks.Length; i++) {
            counters[tasks[i]-'A']++;
        }
        var maxCount = counters.Max();
        var tasksWithMaxCount = counters.Count(c => c==maxCount);
        
        var partsCount = maxCount - 1;
        var partLength = n - (tasksWithMaxCount - 1);
        var emptySlots = partsCount * partLength;
        var availableTasks = tasks.Length - (tasksWithMaxCount * maxCount);
        var idles = Math.Max(0, emptySlots - availableTasks);
        
        return tasks.Length + idles;
    }
}
