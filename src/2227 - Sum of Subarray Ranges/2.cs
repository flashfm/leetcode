// Copyright (c) 2024 Alexey Filatov
// 2227 - Sum of Subarray Ranges (https://leetcode.com/problems/sum-of-subarray-ranges)
// Date solved: 10/22/2024 9:54:11 PM +00:00
// Memory: 44.3 MB
// Runtime: 17 ms


public class Solution {
    public long SubArrayRanges(int[] nums) {
        var n = nums.Length;

        var lmin = BuildArr(nums, Enumerable.Range(0, n), (a,b) => a>b, false);
        var rmin = BuildArr(nums, Enumerable.Range(0, n).Reverse(), (a,b) => a>=b, true);
        var lmax = BuildArr(nums, Enumerable.Range(0, n), (a,b) => a<=b, false);
        var rmax = BuildArr(nums, Enumerable.Range(0, n).Reverse(), (a,b) => a<b, true);

        long result = 0;
        for(var i = 0; i<n; i++) {
            result += nums[i] * (lmax[i]+1) * (rmax[i]+1) - nums[i] * (lmin[i]+1) * (rmin[i]+1);
        }

        return result;
    }

    private long[] BuildArr(int[] nums, IEnumerable<int> indexRange, Func<int, int, bool> f, bool right)
    {
        var n = nums.Length;
        var lmax = new long[n];
        var stack = new Stack<int>();
        foreach(var i in indexRange) {
            while(stack.Count > 0 && f(nums[stack.Peek()], nums[i])) {
                stack.Pop();
            }
            lmax[i] = right ? (stack.Count==0 ? n-i-1 : stack.Peek()-i-1 ) : (stack.Count==0 ? i : i-stack.Peek()-1);
            stack.Push(i);
        }
        return lmax;
    }
}
