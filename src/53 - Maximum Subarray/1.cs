// Copyright (c) 2020 Alexey Filatov
// 53 - Maximum Subarray (https://leetcode.com/problems/maximum-subarray)
// Date solved: 3/17/2020 4:20:33 AM +00:00
// Memory: 25.3 MB
// Runtime: 100 ms


public class Solution {
    public int MaxSubArray(int[] nums) {
        var sumSoFar = 0;
        var result = int.MinValue;
        for(var i=0; i<nums.Length; i++) {
            var n = nums[i];
            
            sumSoFar += n;
            
            if (sumSoFar > result) {
                result = sumSoFar;
            }
            
            if (sumSoFar<0) {
                sumSoFar = 0;
            }
        }
        return result;
    }
}
