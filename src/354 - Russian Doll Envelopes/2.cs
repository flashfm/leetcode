// Copyright (c) 2024 Alexey Filatov
// 354 - Russian Doll Envelopes (https://leetcode.com/problems/russian-doll-envelopes)
// Date solved: 12/29/2024 5:06:21 AM +00:00
// Memory: 80.4 MB
// Runtime: 79 ms


public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        Array.Sort(envelopes, (a, b) => a[0]==b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));
        //Console.WriteLine(string.Join(",", envelopes.Select(e => (e[0], e[1]))));
        var tails = new List<int>(envelopes.Length);
        foreach(var e in envelopes) {
            var h = e[1];
            var i = tails.BinarySearch(h);
            if (i<0) {
                var idx = ~i;
                if (idx<tails.Count) {
                    tails[idx] = h;
                }
                else {
                    tails.Add(h);
                }
            }
        }
        return tails.Count;
    }
}
