// Copyright (c) 2024 Alexey Filatov
// 1762 - Furthest Building You Can Reach (https://leetcode.com/problems/furthest-building-you-can-reach)
// Date solved: 11/1/2024 6:07:05 PM +00:00
// Memory: 68.7 MB
// Runtime: 28 ms


public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        var minHeap = new PriorityQueue<int, int>();
        var sum = 0;
        for(var i = 1; i<heights.Length; i++) {
            var d = heights[i] - heights[i-1];
            if (d<=0) {
                continue;
            }
            if (minHeap.Count<ladders) {
                minHeap.Enqueue(d, d);
            }
            else if (minHeap.Count>0 && d>minHeap.Peek()) {
                sum += minHeap.DequeueEnqueue(d, d);
            }
            else {
                sum += d;
            }
            if (sum>bricks) {
                return i-1;
            }
        }
        return heights.Length-1;
    }
}
