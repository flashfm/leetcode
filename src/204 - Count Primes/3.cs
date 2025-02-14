// Copyright (c) 2020 Alexey Filatov
// 204 - Count Primes (https://leetcode.com/problems/count-primes)
// Date solved: 3/16/2020 8:09:48 AM +00:00
// Memory: 16.9 MB
// Runtime: 84 ms


public class Solution {
    public int CountPrimes(int n) {
        var a = new bool[n];
        for(var i = 2; i*i<=n; i++) {
            if (a[i]) continue;
            for(var j=i; j<=n/i; j++) {
                if (i*j<n) a[i*j] = true;
            }           
        }      
        var result = 0;
        for(var i = 2; i<n; i++) if (!a[i]) result++;
        return result;
    }
}
