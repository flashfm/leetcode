// Count and Say
// https://leetcode.com/problems/count-and-say
// Date solved: 03/21/2020 06:24:56 +00:00

public class Solution {
    public string CountAndSay(int n) {
        var s = new List<char> {'1'};
        for(var i=1;i<n;i++) {
            s = Transform(s);
        }
        return new string(s.ToArray());
    }
    private List<char> Transform(List<char> s)
    {
        var result = new List<char>();
        var c = 1;
        for(var i = 0; i<s.Count; i++) {
            if (i<s.Count-1 && s[i]==s[i+1]) {
                c++;
            }
            else {
                if (c<9) {
                    result.Add((char)('0'+c));
                }
                else {
                    result.AddRange(c.ToString().ToArray());
                }
                result.Add(s[i]);
                c=1;
            }
        }
        return result;
    }
}
