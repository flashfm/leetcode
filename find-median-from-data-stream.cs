// Find Median from Data Stream
// https://leetcode.com/problems/find-median-from-data-stream
// Date solved: 04/02/2020 05:40:13 +00:00

    public class MedianFinder
    {
        private Heap minHeap = new Heap(true);
        private Heap maxHeap = new Heap(false);
        
        public MedianFinder()
        {

        }

        public void AddNum(int num)
        {
            if (maxHeap.Count == 0) {
                maxHeap.Add(num);
                return;
            }
            // 5,1,7,0,3,4
            // 0,1,3,4,5,7 => (3+4)/2, 3 is max, 4 is min
            // size of heaps diff just 1 max, otherwise move number from one heap to another
            var left = maxHeap.Top;
            (num > left ? minHeap : maxHeap).Add(num);

            if (minHeap.Count == maxHeap.Count + 2) {
                maxHeap.Add(minHeap.Pop());
            }
            else if (maxHeap.Count == minHeap.Count + 2) {
                minHeap.Add(maxHeap.Pop());
            }
        }
        
        public double FindMedian()
        {
            if (maxHeap.Count > minHeap.Count) return maxHeap.Top;
            if (minHeap.Count > maxHeap.Count) return minHeap.Top;
            return (minHeap.Top + maxHeap.Top) / (double)2;
        }
    }

    public class Heap
    {
        private class Item: IComparer<Item>
        {
            public int Val;
            private Guid Guid = Guid.NewGuid();

            public int Compare(Item x, Item y)
                => x.Val == y.Val ? x.Guid.CompareTo(y.Guid) : x.Val.CompareTo(y.Val);
        }

        private readonly bool isMin;
        private readonly SortedSet<Item> items = new SortedSet<Item>(new Item());

        public int Top => isMin ? items.Min.Val : items.Max.Val;
        public int Count => items.Count;

        public void Add(int val)
        {
            items.Add(new Item { Val = val });
        }

        public int Pop()
        {
            var item = isMin ? items.Min : items.Max;
            items.Remove(item);
            return item.Val;
        }

        public Heap(bool isMin)
        {
            this.isMin = isMin;
        }
    }

