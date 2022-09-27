// Task Scheduler
// https://leetcode.com/problems/task-scheduler
// Date solved: 01/06/2020 06:24:46 +00:00

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
