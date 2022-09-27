// Sliding Window Maximum
// https://leetcode.com/problems/sliding-window-maximum
// Date solved: 04/02/2020 06:01:39 +00:00

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var heap = new Heap(false);
        for(var i=0;i<k;i++) heap.Add(nums[i]);
        var result = new List<int>();
        result.Add(heap.Top);
        for(var i=k;i<nums.Length;i++) {
            heap.Add(nums[i]);
            heap.Remove(nums[i-k]);
            result.Add(heap.Top);
        }
        return result.ToArray();
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
        private readonly Dictionary<int, List<Item>> itemsByVal = new Dictionary<int, List<Item>>(); 

        public int Top => isMin ? items.Min.Val : items.Max.Val;
        public int Count => items.Count;

        public void Add(int val)
        {
            var item = new Item { Val = val };
            if (!itemsByVal.TryGetValue(val, out var list)) {
                itemsByVal[val] = list = new List<Item>();
            }
            list.Add(item);
            items.Add(item);
        }

        public int Pop()
        {
            var item = isMin ? items.Min : items.Max;
            items.Remove(item);
            return item.Val;
        }
        
        public void Remove(int val)
        {
            var list = itemsByVal[val];
            var item = list[list.Count-1];
            list.RemoveAt(list.Count-1);
            items.Remove(item);
        }

        public Heap(bool isMin)
        {
            this.isMin = isMin;
        }
    }

}
