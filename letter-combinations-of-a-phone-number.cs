// Letter Combinations of a Phone Number
// https://leetcode.com/problems/letter-combinations-of-a-phone-number
// Date solved: 12/09/2019 09:12:36 +00:00

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
        if (digits.Length==0) return new string[0];
        return Gen(digits, 0).ToList();
    }
  
    private IEnumerable<string> Gen(string digits, int pos)
    {
      if (pos==digits.Length) {
        yield return "";
        yield break;
      }
      var letters = mapping[digits[pos]];
      if (letters.Length==0) {
        yield return "";
        yield break;
      }
      foreach(var letter in letters) {
        foreach(var postfix in Gen(digits, pos+1)) {
          yield return letter + postfix;
        }
      }
    }
}
