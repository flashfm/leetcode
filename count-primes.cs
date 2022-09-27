// Count Primes
// https://leetcode.com/problems/count-primes
// Date solved: 03/16/2020 08:11:05 +00:00

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
