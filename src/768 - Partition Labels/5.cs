// Copyright (c) 2024 Alexey Filatov
// 768 - Partition Labels (https://leetcode.com/problems/partition-labels)
// Date solved: 12/10/2024 7:12:12 AM +00:00
// Memory: 46.3 MB
// Runtime: 2 ms


public class Solution {
    public IList<int> PartitionLabels(string s) {
        var n = s.Length;
        var indexOfLetter = new int[26];
        Array.Fill(indexOfLetter, -1);
        for(var i=0; i<n; i++) {
            indexOfLetter[s[i]-'a'] = i;
        }
        var result = new List<int>();
        var prev = -1;
        var max = 0;
        for(var i=0; i<n; i++) {
            max = Math.Max(max, indexOfLetter[s[i]-'a']);
            if (max==i) {
                result.Add(max - prev);
                prev = max;
            }
        }
        return result;
    }
}
