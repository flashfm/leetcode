// Copyright (c) 2020 Alexey Filatov
// 189 - Rotate Array (https://leetcode.com/problems/rotate-array)
// Date solved: 3/14/2020 1:31:13 AM +00:00
// Memory: 32.2 MB
// Runtime: 236 ms


public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums==null) return;
        
        var n = nums.Length;
        if (n==0) return;
        
        k %= n;        
        if (k==0) return;

        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, n-k);
    }
}
