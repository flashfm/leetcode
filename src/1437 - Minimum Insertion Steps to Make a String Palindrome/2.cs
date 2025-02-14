// Copyright (c) 2025 Alexey Filatov
// 1437 - Minimum Insertion Steps to Make a String Palindrome (https://leetcode.com/problems/minimum-insertion-steps-to-make-a-string-palindrome)
// Date solved: 1/5/2025 7:04:28 PM +00:00
// Memory: 42.2 MB
// Runtime: 18 ms


public class Solution {
    public int MinInsertions(string s) {

        var n = s.Length;
        var dp = new int[n,n+1];
        for(var len=1; len<n+1; len++) {
            for(var start=0; start<n; start++) {
                dp[start, len] = len<=1 || start+len-1>=n ? 0 : (
                    s[start]==s[start+len-1] ? dp[start+1, len-2] :
                        1 + Math.Min(dp[start+1, len-1], dp[start, len-1]));

            }
        }

        return dp[0, n];
    }
}

