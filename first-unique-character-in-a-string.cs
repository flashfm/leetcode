// First Unique Character in a String
// https://leetcode.com/problems/first-unique-character-in-a-string
// Date solved: 03/15/2020 05:45:42 +00:00

public class Solution {
    public int FirstUniqChar(string s) {
        var dict = new Dictionary<char, int>();
        for(var i = 0; i<s.Length; i++) {
            var c = s[i];
            dict[c] = dict.ContainsKey(c) ? -1 : i;
        }
        var vals = dict.Values.Where(v => v!=-1).ToList();
        return vals.Count==0 ? -1 : vals.Min();
    }
}
