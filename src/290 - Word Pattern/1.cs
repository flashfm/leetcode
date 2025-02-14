// Copyright (c) 2022 Alexey Filatov
// 290 - Word Pattern (https://leetcode.com/problems/word-pattern)
// Date solved: 1/17/2022 4:14:59 PM +00:00
// Memory: 36.1 MB
// Runtime: 139 ms


public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if (words.Length != pattern.Length) {
            return false;
        }
        var letterByWord = new Dictionary<string, char>();
        var wordByLetter = new Dictionary<char, string>();
        for(var i = 0; i<words.Length; i++) {
            var word = words[i];
            var letter = pattern[i];
            if (wordByLetter.TryGetValue(letter, out var testWord)) {
                if (word != testWord) { return false; }
            }
            else {
                wordByLetter[letter] = word;
            }
            
            if (letterByWord.TryGetValue(word, out var testLetter)) {
                if (letter != testLetter) { return false; }
            }
            else {
                letterByWord[word] = letter;
            }
        }
        return true;
    }
}
