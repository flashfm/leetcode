// Copyright (c) 2024 Alexey Filatov
// 35 - Search Insert Position (https://leetcode.com/problems/search-insert-position)
// Date solved: 10/10/2024 10:18:20 PM +00:00
// Memory: 42.4 MB
// Runtime: 67 ms


public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var l = 0;
        var r = nums.Length-1;
        int mid = 0;
        while(l<r) {
            mid = (l+r)/2;
            if (nums[mid]==target) {
                return mid;
            }
            else if (nums[mid]<target) {
                l = mid+1;
            }
            else {
                r = mid;
            }
        }
        return nums[l]<target ? l+1 : l;
    }
}
