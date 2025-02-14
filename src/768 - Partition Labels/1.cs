// Copyright (c) 2024 Alexey Filatov
// 768 - Partition Labels (https://leetcode.com/problems/partition-labels)
// Date solved: 12/10/2024 6:38:26 AM +00:00
// Memory: 46.5 MB
// Runtime: 3 ms


public class Solution {
    public IList<int> PartitionLabels(string s) {
        var firstPosOfLetter = new int[26];
        Array.Fill(firstPosOfLetter, -1);
        var cur = 0;
        var n = s.Length;
        var part = new int[n];
        var partLeft = new int[n+1];
        partLeft[0] = -1;
        for(var i=0; i<n; i++) {
            var j = s[i]-'a';
            if (firstPosOfLetter[j]==-1) {
                firstPosOfLetter[j] = i;
                cur++;
            }
            else {
                var firstPos = firstPosOfLetter[j];
                cur = part[firstPos];
                for(var a=firstPos; a<i; a++) {
                    part[a] = cur;
                }
            }
            part[i] = cur;
            partLeft[cur] = i;
        }
        var result = new List<int>();
        for(var i=1; i<=part[n-1]; i++) {
            result.Add(partLeft[i]-partLeft[i-1]);
        }
        return result;
    }
}
