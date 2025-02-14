// Copyright (c) 2024 Alexey Filatov
// 2636 - Maximum Subsequence Score (https://leetcode.com/problems/maximum-subsequence-score)
// Date solved: 11/17/2024 4:38:36 AM +00:00
// Memory: 75.9 MB
// Runtime: 155 ms


public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        var pairs = nums1.Select((n,i) => (n, nums2[i])).OrderByDescending(pair => pair.Item2).ToArray();
        var minHeap = new PriorityQueue<int, int>();
        long sum = 0;
        long result = 0;
        for(var i = 0; i<nums1.Length; i++) {
            sum += pairs[i].Item1;
            minHeap.Enqueue(pairs[i].Item1, pairs[i].Item1);
            if (i>=k) {
                sum -= minHeap.Dequeue();
            }
            if (i>=k-1) {
                result = Math.Max(result, sum * pairs[i].Item2);
            }
        }
        return result;
    }
}
