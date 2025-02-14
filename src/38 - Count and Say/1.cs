// Copyright (c) 2020 Alexey Filatov
// 38 - Count and Say (https://leetcode.com/problems/count-and-say)
// Date solved: 3/21/2020 6:17:53 AM +00:00
// Memory: 24.4 MB
// Runtime: 88 ms


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
                result.AddRange(c.ToString().ToArray());
                result.Add(s[i]);
                c=1;
            }
        }
        return result;
    }
}
