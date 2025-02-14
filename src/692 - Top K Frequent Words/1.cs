// Copyright (c) 2024 Alexey Filatov
// 692 - Top K Frequent Words (https://leetcode.com/problems/top-k-frequent-words)
// Date solved: 10/31/2024 7:52:41 PM +00:00
// Memory: 51.3 MB
// Runtime: 5 ms


public class Solution {
    private class Comparer: IComparer<(string Word, int Count)>
    {
        public int Compare((string Word, int Count) a, (string Word, int Count) b)
        {
            var r = a.Count.CompareTo(b.Count);
            return r==0 ? -a.Word.CompareTo(b.Word) : r;
        }
    }

    public IList<string> TopKFrequent(string[] words, int k) {
        var dict = new Dictionary<string, int>();
        foreach(var word in words) {
            dict[word] = dict.GetValueOrDefault(word) + 1;
        }
        var heap = new PriorityQueue<string, (string, int)>(new Comparer());
        foreach(var (word, count) in dict) {
            heap.Enqueue(word, (word, count));
            if (heap.Count>k) {
                heap.Dequeue();
            }
        }
        var result = new List<string>();
        while(heap.Count>0) {
            result.Add(heap.Dequeue());
        }
        result.Reverse();
        return result;
    }
}
