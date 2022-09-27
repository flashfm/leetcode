// Group Anagrams
// https://leetcode.com/problems/group-anagrams
// Date solved: 01/07/2020 06:01:57 +00:00

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var s in strs) {
            var key = CreateKey(s);
            if (!dict.TryGetValue(key, out var list)) {
                list = new List<string>();
                dict[key] = list;
            }
            list.Add(s);
        }
        return dict.Values.Cast<IList<string>>().ToList();
    }
    private string CreateKey(string s)
    {
        var a = new int[26];
        foreach(var c in s) {
            a[c-'a']++;
        }
        var sb = new StringBuilder();
        for(var i=0;i<a.Length;i++) {
            var n = a[i];
            if (n>0) {
                sb.Append(i+'a').Append(n);
            }
        }
        return sb.ToString();
    }
}
