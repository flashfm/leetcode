// Copyright (c) 2024 Alexey Filatov
// 402 - Remove K Digits (https://leetcode.com/problems/remove-k-digits)
// Date solved: 10/25/2024 5:15:48 AM +00:00
// Memory: 44.4 MB
// Runtime: 6 ms


public class Solution {
    public string RemoveKdigits(string num, int k) {
        var n = num.Length;
        var stack = new Stack<char>();
        for(var i = 0; i<n; i++) {
            var c = num[i];
            while (k>0 && stack.Count > 0 && c < stack.Peek()) {
                stack.Pop();
                k--;
            }
            stack.Push(c);
        }
        while(k>0) {
            stack.Pop();
            k--;
        }
        var result = new string(stack.Reverse().ToArray()).TrimStart('0');
        return result == "" ? "0" : result;
    }
}
