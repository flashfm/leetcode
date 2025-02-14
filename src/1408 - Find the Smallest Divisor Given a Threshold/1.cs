// Copyright (c) 2020 Alexey Filatov
// 1408 - Find the Smallest Divisor Given a Threshold (https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold)
// Date solved: 11/6/2020 8:52:32 AM +00:00
// Memory: 32.1 MB
// Runtime: 136 ms


// a1/x + a2/x + ... + an/x <= threshold, actually ceil(a1/x) + ... + ceil(an/x) <= threshold,
// find min x
// a1 + a2 + ... + an <= threshold * x
// sum / threshold <= x

// ceil(a1/x) = a1/x if a1%x==0 otherwise round(a1/x)+1

// sum / threshold is the left (smallest) value in possible range
// right val?
// when all of numbers give round(ai/x)+1, let's say ai/x+1
// a1/x+...an/x + len <= threshold
// sum <= (threshold-len) * x
// sum / (threshold-len) <= x

public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        var len = nums.Length;
        long sum = 0;
        for(var i = 0; i<nums.Length; i++) {
            sum += nums[i];
        }
        var l = (int)Math.Round((double)sum / threshold);
        if (l==0) l=1;
        var r = threshold<=len ? -1 : (int)Math.Round((double)sum / (threshold-len));
        while(l<=r) {
            var m = (l+r)/2;
            var sum1 = GetSumCeil(m, nums, threshold);
            if (sum1<=threshold) {
                r = m-1;
            }
            else {
                l = m+1;
            }
        }
        //Console.WriteLine(l+","+r);
        return l;
    }
    private int GetSumCeil(int x, int[] nums, int threshold)
    {
        var sum = 0;
        for(var i = 0; i<nums.Length; i++) {
            sum += (int)Math.Ceiling((double)nums[i] / x);
        }
        return sum;
    }
}
