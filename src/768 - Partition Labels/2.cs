// Copyright (c) 2024 Alexey Filatov
// 768 - Partition Labels (https://leetcode.com/problems/partition-labels)
// Date solved: 12/10/2024 6:44:18 AM +00:00
// Memory: 46.2 MB
// Runtime: 3 ms


public class Solution {
    public IList<int> PartitionLabels(string s) {
        var firstPosOfLetter = new int[26];
        Array.Fill(firstPosOfLetter, -1);
        var cur = 0;
        var n = s.Length;
        var partitionOfLetter = new int[26];
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
                cur = partitionOfLetter[j];
                for(var a=firstPos+1; a<i; a++) {
                    partitionOfLetter[s[a]-'a'] = cur;
                }
            }
            partitionOfLetter[j] = cur;
            partLeft[cur] = i;
        }
        var result = new List<int>();
        for(var i=1; i<=partitionOfLetter[s[n-1]-'a']; i++) {
            result.Add(partLeft[i]-partLeft[i-1]);
        }
        return result;
    }
}
