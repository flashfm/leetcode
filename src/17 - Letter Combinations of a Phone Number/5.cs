// Copyright (c) 2019 Alexey Filatov
// 17 - Letter Combinations of a Phone Number (https://leetcode.com/problems/letter-combinations-of-a-phone-number)
// Date solved: 12/22/2019 7:35:37 AM +00:00
// Memory: 30.9 MB
// Runtime: 272 ms


public class Solution {
    private string[] mapping = new string[] {
      "0", "1",
      "abc",
      "def",
      "ghi",
      "jkl",
      "mno",
      "pqrs",
      "tuv",
      "wxyz"
   };
    public IList<string> LetterCombinations(string digits) {
      var list = new List<string>();
      if (digits.Length==0) return list;
      list.Add("");
      for(var i=0;i<digits.Length;i++) {
        var letters = mapping[digits[i]-'0'];
        var newList = new List<string>(list.Count * letters.Length);
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
