// Copyright (c) 2020 Alexey Filatov
// 532 - K-diff Pairs in an Array (https://leetcode.com/problems/k-diff-pairs-in-an-array)
// Date solved: 10/3/2020 11:24:51 PM +00:00
// Memory: 31.6 MB
// Runtime: 116 ms


public class Solution {
    public int FindPairs(int[] nums, int k) {
        var numsSoFar = new HashSet<int>();
        var pairs = new HashSet<(int,int)>();
        int result = 0;
        var coef = new int[] {-1,1};
        foreach(var num in nums) {
            int count;
            foreach(var i in coef) {
                var c = num + i*k;
                if (!pairs.Contains((num,c)) && !pairs.Contains((c,num)) && numsSoFar.Contains(c)) {
                    result++;
                    pairs.Add((num,c));
                    pairs.Add((c,num));
                }
            }
            numsSoFar.Add(num);
        }
        return result;
    }
}
