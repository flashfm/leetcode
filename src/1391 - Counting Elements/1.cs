// Copyright (c) 2020 Alexey Filatov
// 1391 - Counting Elements (https://leetcode.com/problems/counting-elements)
// Date solved: 4/9/2020 6:03:48 AM +00:00
// Memory: 23.9 MB
// Runtime: 96 ms


public class Solution {
    public int CountElements(int[] arr) {
        var set = arr.ToHashSet();
        var count = 0;
        foreach(var a in arr) {
            if (set.Contains(a+1)) {
                count++;
            }
        }
        return count;
    }
}
