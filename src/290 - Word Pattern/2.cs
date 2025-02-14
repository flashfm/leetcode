// Copyright (c) 2022 Alexey Filatov
// 290 - Word Pattern (https://leetcode.com/problems/word-pattern)
// Date solved: 1/17/2022 4:25:33 PM +00:00
// Memory: 36.2 MB
// Runtime: 167 ms


public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if (words.Length != pattern.Length) {
            return false;
        }
        var indexByWord = new Dictionary<string, int>();
        var indexByLetter = new Dictionary<char, int>();
        for(var i = 0; i<words.Length; i++) {
            var word = words[i];
            var letter = pattern[i];
            indexByWord.TryGetValue(word, out var i1);
            indexByLetter.TryGetValue(letter, out var i2);
            if (i1!=i2) {
                return false;
            }
            indexByWord[word] = indexByLetter[letter] = i+1;
        }
        return true;
    }
}
