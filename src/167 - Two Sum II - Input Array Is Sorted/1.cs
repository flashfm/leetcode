// Copyright (c) 2024 Alexey Filatov
// 167 - Two Sum II - Input Array Is Sorted (https://leetcode.com/problems/two-sum-ii-input-array-is-sorted)
// Date solved: 8/28/2024 5:16:34 PM +00:00
// Memory: 49.6 MB
// Runtime: 117 ms


public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var s = 0;
        var e = numbers.Length-1;
        while(numbers[e]+numbers[s] != target) {
            if (numbers[e] + numbers[s] > target) {
                e--;
            }
            else {
                s++;
            }
        }
        return new int[] { s+1, e+1 };
    }
}
