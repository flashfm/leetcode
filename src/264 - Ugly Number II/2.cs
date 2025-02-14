// Copyright (c) 2020 Alexey Filatov
// 264 - Ugly Number II (https://leetcode.com/problems/ugly-number-ii)
// Date solved: 7/21/2020 10:08:54 AM +00:00
// Memory: 16.9 MB
// Runtime: 72 ms


// remove multipliers of 7, 11, 13, 17, ... i.e. other primes
// stop when prime is > 1690 (or when Nth numbers are left behind the prime)

public class Solution {
    public int NthUglyNumber(int n) {
            var result = new List<int>();
            result.Add(1);
            var i = 0;
            var j = 0;
            var k = 0;
            while(result.Count<n) {
                var a = result[i]*2;
                var b = result[j]*3;
                var c = result[k]*5;
                var x = Math.Min(a, Math.Min(b, c));
                result.Add(x);
                if (a==x) i++;
                if (b==x) j++;
                if (c==x) k++;
            }

            return result[n-1];
    }
}
