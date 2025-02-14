// Copyright (c) 2020 Alexey Filatov
// 204 - Count Primes (https://leetcode.com/problems/count-primes)
// Date solved: 3/16/2020 8:11:05 AM +00:00
// Memory: 17 MB
// Runtime: 60 ms


public class Solution {
    public int CountPrimes(int n) {
        var a = new bool[n];
        for(var i = 2; i*i<n; i++) {
            if (a[i]) continue;
            for(var k=i*i; k<n; k+=i) {
                a[k] = true;
            }           
        }      
        var result = 0;
        for(var i = 2; i<n; i++) if (!a[i]) result++;
        return result;
    }
}
