// Longest Substring Without Repeating Characters
// https://leetcode.com/problems/longest-substring-without-repeating-characters
// Date solved: 01/18/2020 05:26:57 +00:00

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var result = 0;
        var map = new Dictionary<char, int>();
        for(int i=0, j=0; j<s.Length; j++) {
            if (map.ContainsKey(s[j])) {
                i = Math.Max(i, map[s[j]]);
            }
            result = Math.Max(result, j-i+1);
            map[s[j]] = j+1;
        }
        return result;
    }
}
