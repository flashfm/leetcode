// Copyright (c) 2024 Alexey Filatov
// 1018 - Largest Perimeter Triangle (https://leetcode.com/problems/largest-perimeter-triangle)
// Date solved: 12/18/2024 9:04:58 PM +00:00
// Memory: 49 MB
// Runtime: 34 ms


public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        var i = nums.Length-1;
        while(i-2>=0 && nums[i] >= nums[i-1] + nums[i-2]) {
            i--;
        }
        return i-2>=0 ? nums[i] + nums[i-1] + nums[i-2] : 0;
    }
}
