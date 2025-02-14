// Copyright (c) 2024 Alexey Filatov
// 2413 - Smallest Number in Infinite Set (https://leetcode.com/problems/smallest-number-in-infinite-set)
// Date solved: 11/16/2024 6:49:25 PM +00:00
// Memory: 75 MB
// Runtime: 3 ms


public class SmallestInfiniteSet {
    int cur = 1;
    PriorityQueue<int,int> minHash = new();
    bool[] hashset = new bool[1001];
    public SmallestInfiniteSet() {
        
    }
    
    public int PopSmallest() {
        if (minHash.Count>0 && minHash.Peek()<cur) {
            var result = minHash.Dequeue();
            hashset[result] = false;
            return result;
        }
        else {
            return cur++; 
        }
    }
    
    public void AddBack(int num) {
        if (num<cur && !hashset[num]) {
            hashset[num] = true;
            minHash.Enqueue(num, num);
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
