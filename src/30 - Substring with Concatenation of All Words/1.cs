// Copyright (c) 2024 Alexey Filatov
// 30 - Substring with Concatenation of All Words (https://leetcode.com/problems/substring-with-concatenation-of-all-words)
// Date solved: 9/24/2024 2:56:51 AM +00:00
// Memory: 57 MB
// Runtime: 625 ms


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
        for(var i = 0; i<s.Length; i++) {
            if (wordIndexes[i]==-1) {
                continue;
            }
            var clone = new Dictionary<int, int>(countByWordIndex);
            // fill window
            var lim = i+words.Length*wordLen;
            //Console.WriteLine("Lim: " + lim);
            if (lim>s.Length) {
                break;
            }
            for(var x = i; x<lim; x += wordLen) {
                var wordIndex = wordIndexes[x];
                if (wordIndex==-1) {
                    break;
                }
                //Console.WriteLine(x + " -> " + wordIndex);
                Decrease(clone, wordIndex);
            }
            if (clone.Count==0) {
                result.Add(i);
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

    private void Decrease(Dictionary<int, int> dict, int key)
    {
        if (dict.TryGetValue(key, out var count)) {
            count--;
            if (count==0) {
                dict.Remove(key);
            }
            else {
                dict[key] = count;
            }
        }
    }
}
