// Copyright (c) 2021 Alexey Filatov
// 454 - 4Sum II (https://leetcode.com/problems/4sum-ii)
// Date solved: 9/27/2021 3:55:05 AM +00:00
// Memory: 28.3 MB
// Runtime: 264 ms


public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        var n = nums1.Length;
        var expected = new Dictionary<int, int>();
        for(var k = 0; k<n; k++) {
            for(var l = 0; l<n; l++) {
                var x = -(nums3[k]+nums4[l]);
                expected.TryGetValue(x, out var c);
                expected[x] = c+1;
            }
        }
        var result = 0;
        for(var i = 0; i<n; i++) {
            for(var j = 0; j<n; j++) {
                var x = nums1[i] + nums2[j];
                if (expected.TryGetValue(x, out var c)) {
                    result += c;
                }
            }
        }
        return result;
    }
}
