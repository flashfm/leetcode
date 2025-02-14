// Copyright (c) 2020 Alexey Filatov
// 347 - Top K Frequent Elements (https://leetcode.com/problems/top-k-frequent-elements)
// Date solved: 1/11/2020 6:42:21 AM +00:00
// Memory: 33.8 MB
// Runtime: 260 ms


public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var num in nums) {
            dict.TryGetValue(num, out var count);
            dict[num] = count+1;
        }
        var pairs = dict.Select(p => new Pair {Value=p.Key, Count=p.Value}).ToList();
        var heap = new SortedSet<Pair>(new Comparer());
        foreach(var pair in pairs) {
            if (heap.Count<k) {
                heap.Add(pair);
            }
            else {
                if (pair.Count > heap.Min.Count) {
                    heap.Add(pair);
                    if (heap.Count>k) {
                        heap.Remove(heap.Min);
                    }
                }
            }
        }
        return heap.OrderByDescending(p=>p.Count).Select(p => p.Value).ToList();
    }
    public class Comparer: IComparer<Pair>
    {
        public int Compare(Pair a, Pair b)
        {
            var result = a.Count.CompareTo(b.Count);
            return result==0 ? a.Guid.CompareTo(b.Guid) : result;
        }
    }
    
    public class Pair
    {
        public int Value {get;set;}
        public int Count {get;set;}    
        public Guid Guid {get;} = Guid.NewGuid();
    }
}

// 1 - 1
// 2 - 1

