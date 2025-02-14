// Copyright (c) 2024 Alexey Filatov
// 30 - Substring with Concatenation of All Words (https://leetcode.com/problems/substring-with-concatenation-of-all-words)
// Date solved: 9/24/2024 6:02:53 AM +00:00
// Memory: 128.8 MB
// Runtime: 1198 ms


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
            for(var start = i; start < s.Length; start += wordLen) {
                var clone = new Dictionary<int, int>(countByWordIndex);
                for(var x = 0; x<words.Length; x++) {
                    var index = start + x * wordLen;
                    if (index>=s.Length) {
                        break;
                    }
                    var wordIndex = wordIndexes[index];
                    var count = 0;
                    var found = wordIndex != -1 && clone.TryGetValue(wordIndex, out count) && count > 0;
                    if (!found) {
                        break;
                    }
                    if (count==1) {
                        clone.Remove(wordIndex);
                    }
                    else {
                        clone[wordIndex] = count-1;
                    }
                    if (clone.Count==0) {
                        result.Add(start);
                        break;
                    }
                    //Console.WriteLine(x + " -> " + wordIndex);
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
