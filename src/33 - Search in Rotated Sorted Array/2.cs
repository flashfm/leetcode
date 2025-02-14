// Copyright (c) 2020 Alexey Filatov
// 33 - Search in Rotated Sorted Array (https://leetcode.com/problems/search-in-rotated-sorted-array)
// Date solved: 2/3/2020 6:31:23 AM +00:00
// Memory: 24.9 MB
// Runtime: 92 ms


public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length==0) return -1;
        var b = FindBoundary(nums, 0, nums.Length-1);
        var left = b>-1 && nums[0]<=target && target<=nums[b];
        return left ? BinSearch(nums, target, 0, b) : BinSearch(nums, target, b+1, nums.Length-1);
    }
    private int FindBoundary(int[] nums, int l, int r)
    {
        while(l<r) {
            var m = (l+r)/2;
            if (nums[m]<nums[r]) {
                r = m;
            }
            else {
                l = m+1;
            }
        }
        return l-1;
    }
    private int BinSearch(int[] nums, int target, int l, int r)
    {
        while(l<=r) {
            var mid = (r+l)/2;
            var n = nums[mid];
            if (n==target) return mid;
            if (n>target) {
                r = mid-1;
            }
            else {
                l = mid+1;
            }
        }
        return -1;
    }
}
