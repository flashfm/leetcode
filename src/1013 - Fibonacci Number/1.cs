// Copyright (c) 2024 Alexey Filatov
// 1013 - Fibonacci Number (https://leetcode.com/problems/fibonacci-number)
// Date solved: 12/19/2024 1:33:21 AM +00:00
// Memory: 27.3 MB
// Runtime: 22 ms


public class Solution {
    public int Fib(int n) {
        if (n==0) {
            return 0;
        }
        var f2 = 0;
        var f1 = 1;
        for(var i=2; i<=n; i++) {
            (f1, f2) = (f1 + f2, f1);
        }
        return f1;
    }
}
