// Copyright (c) 2024 Alexey Filatov
// 209 - Minimum Size Subarray Sum (https://leetcode.com/problems/minimum-size-subarray-sum)
// Date solved: 9/9/2024 3:06:09 AM +00:00
// Memory: 51.5 MB
// Runtime: 137 ms


public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        if (nums.Length==0) {
            return 0;
        }
        var l = 0;
        var r = 0;
        var sum = nums[0];
        var result = int.MaxValue;
        while(l<nums.Length) {
            if (sum>=target) {
                result = Math.Min(result, r-l+1);
            }
            if (sum>target && l<r) {
                sum -= nums[l];
                l++;
            }
            else if (r<nums.Length-1) {
                r++;
                sum += nums[r];
            }
            else {
                break;
            }
        }
        return result == int.MaxValue ? 0 : result;
    }
}
