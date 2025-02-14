// Copyright (c) 2024 Alexey Filatov
// 30 - Substring with Concatenation of All Words (https://leetcode.com/problems/substring-with-concatenation-of-all-words)
// Date solved: 9/24/2024 6:26:59 AM +00:00
// Memory: 56.3 MB
// Runtime: 120 ms


public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var result = new List<int>();
        if (s.Length==0 || words.Length==0) {
            return result;
        }
        var countByWord = new Dictionary<string, int>();
        foreach(var word in words) {
            countByWord[word] = countByWord.GetValueOrDefault(word) + 1;
        }
        var wordLen = words[0].Length;
        for(var i = 0; i<wordLen; i++) {
            var current = new Dictionary<string, int>();
            var count = 0;
            var left = i;
            for(var start = i; start < s.Length - wordLen + 1; start += wordLen) {
                var word = s.Substring(start, wordLen);
                if (countByWord.ContainsKey(word)) {
                    current[word] = current.GetValueOrDefault(word) + 1;
                    count++;
                    
                    while(current[word] > countByWord[word]) {
                        current[s.Substring(left, wordLen)]--;
                        count--;
                        left += wordLen;
                    }

                    if (count == words.Length) {
                        result.Add(left);
                    }
                }
                else {
                    current.Clear();
                    count = 0;
                    left = start + wordLen;
                }
            }
        }
        return result;
    }
}
