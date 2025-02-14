// Copyright (c) 2024 Alexey Filatov
// 295 - Find Median from Data Stream (https://leetcode.com/problems/find-median-from-data-stream)
// Date solved: 10/12/2024 12:53:56 AM +00:00
// Memory: 141.1 MB
// Runtime: 591 ms


    public class MedianFinder
    {
        private class MaxComparer : IComparer<int>
        {
            public int Compare(int a, int b) => b.CompareTo(a);
        }

        private PriorityQueue<int, int> minHeap = new();
        private PriorityQueue<int, int> maxHeap = new(new MaxComparer());

        public void AddNum(int num)
        {
            if (maxHeap.Count == 0) {
                maxHeap.Enqueue(num, num);
                return;
            }
            // 5,1,7,0,3,4
            // 0,1,3,4,5,7 => (3+4)/2, 3 is max, 4 is min
            // size of heaps diff just 1 max, otherwise move number from one heap to another
            var left = maxHeap.Peek();
            (num > left ? minHeap : maxHeap).Enqueue(num, num);

            if (minHeap.Count == maxHeap.Count + 2) {
                var min = minHeap.Dequeue();
                maxHeap.Enqueue(min, min);
            }
            else if (maxHeap.Count == minHeap.Count + 2) {
                var max = maxHeap.Dequeue();
                minHeap.Enqueue(max, max);
            }
        }
        
        public double FindMedian()
        {
            if (maxHeap.Count > minHeap.Count) {
                return maxHeap.Peek();
            }
            if (minHeap.Count > maxHeap.Count) {
                return minHeap.Peek();
            }
            return (minHeap.Peek() + maxHeap.Peek()) / (double)2;
        }
    }


