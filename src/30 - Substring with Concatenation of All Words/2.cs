// Copyright (c) 2024 Alexey Filatov
// 30 - Substring with Concatenation of All Words (https://leetcode.com/problems/substring-with-concatenation-of-all-words)
// Date solved: 9/24/2024 3:01:04 AM +00:00
// Memory: 57.8 MB
// Runtime: 635 ms


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
            var clone = new Dictionary<int, int>();
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
                clone[wordIndex] = clone.GetValueOrDefault(wordIndex) + 1;
                //Console.WriteLine(x + " -> " + wordIndex);
            }
            if (IsEqual(countByWordIndex, clone)) {
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

    private bool IsEqual(Dictionary<int, int> a, Dictionary<int, int> b)
    {
        if (a.Count!=b.Count) {
            return false;
        }
        foreach(var (akey, avalue) in a) {
            if (!b.TryGetValue(akey, out var bvalue)) {
                return false;
            }
            if (avalue!=bvalue) {
                return false;
            }
        }
        return true;
    }
}
