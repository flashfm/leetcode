// Copyright (c) 2020 Alexey Filatov
// 204 - Count Primes (https://leetcode.com/problems/count-primes)
// Date solved: 3/16/2020 8:04:07 AM +00:00
// Memory: 16.8 MB
// Runtime: 80 ms


public class Solution {
    public int CountPrimes(int n) {
        var a = new bool[n];
        var sqrt = Math.Sqrt(n);
        for(var i = 2; i<=sqrt; i++) {
            if (a[i]) continue;
            for(var j=2;j<=n/i;j++) {
                if (i*j<n) a[i*j] = true;
            }           
        }      
        var result = 0;
        for(var i = 2; i<n; i++) if (!a[i]) result++;
        return result;
    }
}
