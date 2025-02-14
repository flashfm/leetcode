// Copyright (c) 2019 Alexey Filatov
// 17 - Letter Combinations of a Phone Number (https://leetcode.com/problems/letter-combinations-of-a-phone-number)
// Date solved: 12/9/2019 9:47:32 AM +00:00
// Memory: 30.9 MB
// Runtime: 260 ms


public class Solution {
    private Dictionary<char, string> mapping = new Dictionary<char, string> {
      {'1', "" },
      {'2', "abc"},
      {'3', "def"},
      {'4', "ghi"},
      {'5', "jkl"},
      {'6', "mno"},
      {'7', "pqrs"},
      {'8', "tuv"},
      {'9', "wxyz"},
   };
    public IList<string> LetterCombinations(string digits) {
      var list = new List<string>();
      if (digits.Length==0) return list;
      list.Add("");
      for(var i=0;i<digits.Length;i++) {
        var letters = mapping[digits[i]];
        var newList = new List<string>();
        foreach(var letter in letters) {
          foreach(var comb in list) {
            newList.Add(comb + letter);
          }
        }
        list = newList;
      }
      return list;
    }
}
