// Copyright (c) 2024 Alexey Filatov
// 768 - Partition Labels (https://leetcode.com/problems/partition-labels)
// Date solved: 12/10/2024 7:01:11 AM +00:00
// Memory: 45.8 MB
// Runtime: 6 ms


public class Solution {
    public IList<int> PartitionLabels(string s) {
        var cur = 0;
        var n = s.Length;
        var partitionOfLetter = new int[26];
        for(var i=0; i<n; i++) {
            var j = s[i]-'a';
            if (partitionOfLetter[j]==0) {
                cur++;
                partitionOfLetter[j] = cur;
            }
            else {
                cur = partitionOfLetter[j];
                var a=i-1;
                while(s[a]-'a'!=j) {
                    partitionOfLetter[s[a]-'a'] = cur;
                    a--;
                }
            }
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
