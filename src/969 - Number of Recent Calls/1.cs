// Copyright (c) 2024 Alexey Filatov
// 969 - Number of Recent Calls (https://leetcode.com/problems/number-of-recent-calls)
// Date solved: 11/14/2024 6:33:41 AM +00:00
// Memory: 100.4 MB
// Runtime: 6 ms


public class RecentCounter {

    Queue<int> q = new();

    public RecentCounter() {
        
    }
    
    public int Ping(int t) {
        q.Enqueue(t);
        while(q.Peek()<t-3000) {
            q.Dequeue();
        }
        return q.Count();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
