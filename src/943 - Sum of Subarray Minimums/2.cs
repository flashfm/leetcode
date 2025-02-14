// Copyright (c) 2024 Alexey Filatov
// 943 - Sum of Subarray Minimums (https://leetcode.com/problems/sum-of-subarray-minimums)
// Date solved: 12/4/2024 7:45:05 AM +00:00
// Memory: 50.7 MB
// Runtime: 13 ms


public class Solution {
    public int SumSubarrayMins(int[] arr) {
        var mod = (int)Math.Pow(10, 9) + 7;
        var n = arr.Length;
        // var smallerLeft = new int[n];
        // var smallerRight = new int[n];
        var stack = new Stack<int>();
        var sums = new long[n];
        for(var i=0; i<n; i++) {
            while (stack.Count>0 && arr[i]<=arr[stack.Peek()]) {
                stack.Pop();
            }
            var smallerLeftIndex = stack.Count == 0 ? -1 : stack.Peek();
            sums[i] = (smallerLeftIndex==-1 ? 0 : sums[smallerLeftIndex]) + (i-smallerLeftIndex) * arr[i];
            stack.Push(i);
        }
        return (int)(sums.Sum() % mod);
        // stack.Clear();
        // for(var i=n-1; i>=0; i--) {
        //     while (stack.Count>0 && arr[i]<arr[stack.Peek()]) {
        //         stack.Pop();
        //     }
        //     smallerRight[i] = stack.Count == 0 ? n : stack.Peek();
        //     stack.Push(i);
        // }
        // long result = 0;
        // for(var i=0; i<n; i++) {
        //     result = (result + (long)(i-smallerLeft[i]) * (smallerRight[i]-i) * arr[i]) % mod;
        // }
        //return (int)result;
    }
}
