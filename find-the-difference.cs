// Find the Difference
// https://leetcode.com/problems/find-the-difference
// Date solved: 09/25/2020 05:13:02 +00:00

public class Solution {
    public char FindTheDifference(string s, string t) {
         var dict = new Dictionary<char, int>();
        foreach(var c in s) {
            dict.TryGetValue(c, out var i);
            dict[c] = i+1;
        }
        foreach(var c in t) {
            if (!dict.TryGetValue(c, out var i)) {
                return c;
            }
            i--;
            if (i==0) {
                dict.Remove(c);
            }
            else {
                dict[c] = i;
            }
        }
        throw new Exception("unexpected");
    }
}
