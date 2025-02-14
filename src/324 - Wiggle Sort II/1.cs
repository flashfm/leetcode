// Copyright (c) 2023 Alexey Filatov
// 324 - Wiggle Sort II (https://leetcode.com/problems/wiggle-sort-ii)
// Date solved: 3/8/2023 7:04:36 AM +00:00
// Memory: 50 MB
// Runtime: 154 ms


public class Solution {
    public void WiggleSort(int[] nums) {
        var n = nums.Length;
        Array.Sort(nums);
        var half = n/2;
        if (n%2==0) half--;
        var nums2 = new int[n];
        var even = 0;
        for(var i = 0; i<=half; i++) {
            nums2[even] = nums[half-i];
            even+=2;
        }
        var odd = 1;
        for(var i = 0; odd < n; i++) {
            nums2[odd] = nums[n - 1 - i];
            odd+=2;
        }
        for(var i = 0; i<n; i++) {
            nums[i] = nums2[i];
        }
    }
}
