// Copyright (c) 2024 Alexey Filatov
// 219 - Contains Duplicate II (https://leetcode.com/problems/contains-duplicate-ii)
// Date solved: 9/24/2024 10:36:45 PM +00:00
// Memory: 71.4 MB
// Runtime: 282 ms


public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var maxIndexByNum = new Dictionary<int, int>();
        for(var i = 0; i<nums.Length; i++) {
            var num = nums[i];
            if (maxIndexByNum.TryGetValue(num, out var index)) {
                if (i - index <= k) {
                    return true;
                }
            }
            maxIndexByNum[num] = i;
        }
        return false;
    }
}
