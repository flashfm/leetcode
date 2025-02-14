// Copyright (c) 2024 Alexey Filatov
// 1018 - Largest Perimeter Triangle (https://leetcode.com/problems/largest-perimeter-triangle)
// Date solved: 12/18/2024 9:25:20 PM +00:00
// Memory: 52.4 MB
// Runtime: 15 ms


public class Solution {
    public int LargestPerimeter(int[] nums) {
        var q = new PriorityQueue<int, int>(nums.Select(n => (n, -n)));
        if (q.Count<3) {
            return 0;
        }
        var a1 = q.Dequeue();
        var a2 = q.Dequeue();
        while(q.Count>0) {
            var a3 = q.Dequeue();
            if (a1<a2+a3) {
                return a1+a2+a3;
            }
            (a1, a2) = (a2, a3);
        }
        return 0;
    }
}
