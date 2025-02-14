// Copyright (c) 2024 Alexey Filatov
// 2413 - Smallest Number in Infinite Set (https://leetcode.com/problems/smallest-number-in-infinite-set)
// Date solved: 11/16/2024 9:29:10 PM +00:00
// Memory: 74.6 MB
// Runtime: 5 ms


public class SmallestInfiniteSet {
    int cur = 1;
    SortedSet<int> ss = new();
    public SmallestInfiniteSet() {
        
    }
    
    public int PopSmallest() {
        if (ss.Count>0 && ss.Min<cur) {
            var min = ss.Min;
            ss.Remove(min);
            return min;
        }
        else {
            return cur++; 
        }
    }
    
    public void AddBack(int num) {
        if (num<cur) {
            ss.Add(num);
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
