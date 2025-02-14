// Copyright (c) 2020 Alexey Filatov
// 187 - Repeated DNA Sequences (https://leetcode.com/problems/repeated-dna-sequences)
// Date solved: 10/18/2020 4:27:27 AM +00:00
// Memory: 45.2 MB
// Runtime: 356 ms


public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var dict = new Dictionary<string, int>();
        for(var i = 0; i<s.Length-9; i++) {
            var sub = s.Substring(i, 10);
            dict.TryGetValue(sub, out var count);
            dict[sub] = count+1;
        }
        return dict.Where(pair => pair.Value>1).Select(pair => pair.Key).ToList();
    }
}
