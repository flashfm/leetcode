// Copyright (c) 2024 Alexey Filatov
// 1499 - Maximum Performance of a Team (https://leetcode.com/problems/maximum-performance-of-a-team)
// Date solved: 11/18/2024 5:02:50 AM +00:00
// Memory: 61.1 MB
// Runtime: 58 ms


public class Solution {
    public int MaxPerformance(int n, int[] speed, int[] efficiency, int k) {
        var mod = 1000000007;
        var pairs = speed.Select((s, i) => (s, efficiency[i])).OrderByDescending(p => p.Item2).ToList();
        var minHeap = new PriorityQueue<int, int>();
        long sum = 0;
        long result = 0;
        for(var i = 0; i<n; i++) {
            var s = pairs[i].Item1;
            minHeap.Enqueue(s, s);
            sum += s;
            if (i>=k) {
                sum -= minHeap.Dequeue();
            }
            result = Math.Max(result, sum * pairs[i].Item2);
        }
        return (int)(result % mod);
    }
}
