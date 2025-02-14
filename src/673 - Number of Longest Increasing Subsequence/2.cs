// Copyright (c) 2020 Alexey Filatov
// 673 - Number of Longest Increasing Subsequence (https://leetcode.com/problems/number-of-longest-increasing-subsequence)
// Date solved: 11/3/2020 6:35:36 PM +00:00
// Memory: 26.5 MB
// Runtime: 120 ms


public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        // a[i] - length of sequence ending on i-th number
        // result is number of occurances of max(a) in a
        var n = nums.Length;
        var a = new int[n];
        var counts = new int[n];
        for(var i=0; i<n; i++) { a[i] = 1; counts[i] = 1; }
        for(var i=0; i<n; i++) {
            var num = nums[i];
            for(var j=0; j<i; j++) {
                if (num>nums[j]) {
                    var newLen = a[j]+1;
                    if (newLen>=a[i]) {
                        if (newLen>a[i]) {
                            counts[i] = 0;
                            a[i] = newLen;
                        }
                        counts[i] += counts[j];
                    }
                }
            }
        }
        //Console.WriteLine(string.Join(",", a));
        //Console.WriteLine(string.Join(",", counts));
        var max = int.MinValue;
        for(var i=0; i<n; i++) {
            max = Math.Max(max, a[i]);
        }
        var count = 0;
        for(var i=0; i<n; i++) {
            if (a[i]==max) {
                count += counts[i];
            }
        }
        return count;
    }
}

//1,2,4,5,7
//1,2,3,5,7
//1,2,3,4,7
