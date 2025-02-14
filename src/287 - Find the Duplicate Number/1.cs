// Copyright (c) 2022 Alexey Filatov
// 287 - Find the Duplicate Number (https://leetcode.com/problems/find-the-duplicate-number)
// Date solved: 10/17/2022 4:23:25 AM +00:00
// Memory: 49.9 MB
// Runtime: 411 ms


public class Solution {
    public int FindDuplicate(int[] nums) {
        var hare = nums[0];
        var tortoise = nums[0];
        do {
            tortoise = nums[tortoise];
            hare = nums[nums[hare]];
        } while(hare!=tortoise);
        tortoise = nums[0];
        while(hare!=tortoise) {
            tortoise = nums[tortoise];
            hare = nums[hare];
        }
        return tortoise;
    }
}
