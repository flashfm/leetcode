// Copyright (c) 2024 Alexey Filatov
// 768 - Partition Labels (https://leetcode.com/problems/partition-labels)
// Date solved: 12/10/2024 6:52:12 AM +00:00
// Memory: 46.1 MB
// Runtime: 4 ms


public class Solution {
    public IList<int> PartitionLabels(string s) {
        var firstPosOfLetter = new int[26];
        Array.Fill(firstPosOfLetter, -1);
        var cur = 0;
        var n = s.Length;
        var partitionOfLetter = new int[26];
        for(var i=0; i<n; i++) {
            var j = s[i]-'a';
            if (firstPosOfLetter[j]==-1) {
                firstPosOfLetter[j] = i;
                cur++;
            }
            else {
                cur = partitionOfLetter[j];
                var firstPos = firstPosOfLetter[j];
                for(var a=firstPos+1; a<i; a++) {
                    partitionOfLetter[s[a]-'a'] = cur;
                }
            }
            partitionOfLetter[j] = cur;
        }
        var result = new List<int>();
        var prev = 1;
        var len = 0;
        for(var i=0; i<n; i++) {
            var p = partitionOfLetter[s[i]-'a'];
            if (p!=prev) {
                result.Add(len);
                len = 1;
            }
            else {
                len++;
            }
            prev = p;
        }
        if (len>0) {
            result.Add(len);
        }
        return result;
    }
}
