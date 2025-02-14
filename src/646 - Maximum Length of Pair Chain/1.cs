// Copyright (c) 2024 Alexey Filatov
// 646 - Maximum Length of Pair Chain (https://leetcode.com/problems/maximum-length-of-pair-chain)
// Date solved: 12/26/2024 4:30:08 AM +00:00
// Memory: 50.1 MB
// Runtime: 4 ms


public class Solution {
    public int FindLongestChain(int[][] pairs) {
        Array.Sort(pairs, (a,b) => a[1]-b[1]);
        var prev = pairs[0];
        var result = 1;
        for(var i=1; i<pairs.Length; i++) {
            if (pairs[i][0]>prev[1]) {
                prev = pairs[i];
                result++;
            }
        }
        return result;
    }
}
