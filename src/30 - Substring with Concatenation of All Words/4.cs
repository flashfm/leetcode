// Copyright (c) 2024 Alexey Filatov
// 30 - Substring with Concatenation of All Words (https://leetcode.com/problems/substring-with-concatenation-of-all-words)
// Date solved: 9/24/2024 6:22:44 AM +00:00
// Memory: 52 MB
// Runtime: 129 ms


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
        var countByWordIndex = new Dictionary<int, int>();
        var wordIndexes = new int[s.Length];
        for(var i = 0; i<wordIndexes.Length; i++) {
            wordIndexes[i] = -1;
        }
        var j = 0;
        foreach(var (word,count) in countByWord) {
            countByWordIndex[j] = count;
            SetWordIndexes(wordIndexes, s, word, j);
            j++;
        }

        //Console.WriteLine(string.Join(", ", wordIndexes));

        var wordLen = words[0].Length;
        for(var i = 0; i<wordLen; i++) {
            var current = new Dictionary<int, int>();
            var count = 0;
            var left = i;
            for(var start = i; start < s.Length - wordLen + 1; start += wordLen) {
                var wordIndex = wordIndexes[start];
                if (wordIndex!=-1) {
                    current[wordIndex] = current.GetValueOrDefault(wordIndex) + 1;
                    count++;
                    
                    while(current[wordIndex] > countByWordIndex[wordIndex]) {
                        current[wordIndexes[left]]--;
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

    private void SetWordIndexes(int[] wordIndexes, string s, string word, int i)
    {
        var start = -1;
        do {
            start = s.IndexOf(word, start+1);
            if (start!=-1) {
                wordIndexes[start] = i;
            }
        } while(start!=-1);
    }
}
