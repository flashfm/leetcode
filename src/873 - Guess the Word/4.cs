// Copyright (c) 2024 Alexey Filatov
// 873 - Guess the Word (https://leetcode.com/problems/guess-the-word)
// Date solved: 10/18/2024 5:59:16 AM +00:00
// Memory: 43.6 MB
// Runtime: 74 ms


/**
 * // This is the Master's API interface.
 * // You should not implement it, or speculate about its implementation
 * class Master {
 *     public int Guess(string word);
 * }
 */
class Solution {
    private bool[] ignoreIndex = new bool[6];

    public void FindSecretWord(string[] words, Master master) {
        while(true) {
            var (test, list) = Group(words, words, 0);
            if (list.Count==0 && words.Length>1) {
                // all words has something in common, let's ignore it
                SetIgnoreIndexes(words[0], words[1]);
                (test, _) = Group(words, words, 0);
            }
            var matches = master.Guess(test);
            if (matches==6) {
                return;
            }
            words = Filter(test, words, matches);
        }
    }

    private string[] Filter(string word, IList<string> words, int match)
    {
        return words.Where(x => GetMatches(word, x, false)==match).ToArray();
    }

    private (string, List<string>) Group(IList<string> g1, IList<string> g2, int match)
    {
        (string, List<string>) result = (null, new List<string>());
        int minCount = int.MaxValue;
        foreach(var x in g1) {
            var l = new List<string>();
            foreach(var y in g2) {
                if (x!=y && GetMatches(x, y, true)==match) {
                    l.Add(y);
                }
            }
            if (l.Count<minCount) {
                minCount = l.Count;
                result = (x, l);
            }
        }
        return result;
    }

    private void SetIgnoreIndexes(string w1, string w2)
    {
        for(var i=0;i<6;i++) {
            if (w1[i]==w2[i]) {
                ignoreIndex[i] = true;
            }
        }
    }

    private int GetMatches(string w1, string w2, bool applyIgnore)
    {
        var r = 0;
        for(var i=0;i<6;i++) {
            if ((!applyIgnore || !ignoreIndex[i]) && w1[i]==w2[i]) {
                r++;
            }
        }
        return r;
    }
}
