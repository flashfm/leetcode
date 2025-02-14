// Copyright (c) 2024 Alexey Filatov
// 873 - Guess the Word (https://leetcode.com/problems/guess-the-word)
// Date solved: 10/18/2024 6:04:01 AM +00:00
// Memory: 43.1 MB
// Runtime: 80 ms


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
        return words.Where(x => HasMatches(word, x, match, false)).ToArray();
    }

    private (string, List<string>) Group(IList<string> g1, IList<string> g2, int match)
    {
        (string, List<string>) result = (null, null);
        var minCount = int.MaxValue;
        foreach(var x in g1) {
            var l = g2.Where(y => x!=y && HasMatches(x, y, match, true)).ToList();
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

    private bool HasMatches(string w1, string w2, int matches, bool applyIgnore)
    {
        var r = 0;
        for(var i=0;i<6;i++) {
            if ((!applyIgnore || !ignoreIndex[i]) && w1[i]==w2[i]) {
                r++;
                if (r>matches) {
                    return false;
                }
            }
        }
        return r==matches;
    }
}
