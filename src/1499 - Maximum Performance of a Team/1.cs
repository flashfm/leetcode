// Copyright (c) 2024 Alexey Filatov
// 1499 - Maximum Performance of a Team (https://leetcode.com/problems/maximum-performance-of-a-team)
// Date solved: 11/18/2024 5:01:57 AM +00:00
// Memory: 63.3 MB
// Runtime: 58 ms


public class Solution {
    public int MaxPerformance(int n, int[] speed, int[] efficiency, int k) {
        var mod = 1000000007;
        var pairs = speed.Select((s, i) => new { Speed = s, Efficiency = efficiency[i] }).OrderByDescending(p => p.Efficiency).ToList();
        var minHeap = new PriorityQueue<int, int>();
        long sum = 0;
        long result = 0;
        for(var i = 0; i<n; i++) {
            var s = pairs[i].Speed;
            minHeap.Enqueue(s, s);
            sum += s;
            if (i>=k) {
                sum -= minHeap.Dequeue();
            }
            result = Math.Max(result, sum * pairs[i].Efficiency);
        }
        return (int)(result % mod);
    }
}
