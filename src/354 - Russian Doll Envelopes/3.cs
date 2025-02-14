// Copyright (c) 2024 Alexey Filatov
// 354 - Russian Doll Envelopes (https://leetcode.com/problems/russian-doll-envelopes)
// Date solved: 12/29/2024 5:10:31 AM +00:00
// Memory: 80.8 MB
// Runtime: 76 ms


public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        Array.Sort(envelopes, (a, b) => a[0]==b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));
        //Console.WriteLine(string.Join(",", envelopes.Select(e => (e[0], e[1]))));
        var tails = new int[envelopes.Length];
        var result = 0;
        foreach(var e in envelopes) {
            var h = e[1];
            var i = Array.BinarySearch(tails, 0, result, h);
            if (i<0) {
                var idx = ~i;
                tails[idx] = h;
                if (idx==result) {
                    result++;
                }
            }
        }
        return result;
    }
}
