// Copyright (c) 2024 Alexey Filatov
// 373 - Find K Pairs with Smallest Sums (https://leetcode.com/problems/find-k-pairs-with-smallest-sums)
// Date solved: 10/12/2024 12:46:32 AM +00:00
// Memory: 110.4 MB
// Runtime: 535 ms


public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var queue = new PriorityQueue<int[], int>();
        var result = new List<IList<int>>();
        Enqueue(0, 0);
        while(queue.Count>0 && k-->0) {
            var top = queue.Dequeue();

            var i1 = top[0];
            var i2 = top[1];

            result.Add(new int[] {nums1[i1], nums2[i2]});

            Enqueue(i1, i2+1);
            if (i2==0) {
                Enqueue(i1+1, 0);
            }
        }

        return result;

        void Enqueue(int i1, int i2)
        {
            if (i1<nums1.Length && i2<nums2.Length) {
                queue.Enqueue(new int[] {i1, i2}, nums1[i1] + nums2[i2]);
            }
        }
    }
}
