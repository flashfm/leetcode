// Repeated DNA Sequences
// https://leetcode.com/problems/repeated-dna-sequences
// Date solved: 10/18/2020 04:46:39 +00:00

// 0,1,2,3
// 10 letters
// 3,333,333,333 - long ok
//   333,333,3331 - (rem of div by 10^10) * 10 + digit

public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var dict = new Dictionary<long, int>();
        long cur = 0;
        for(var i = 0; i<s.Length; i++) {
            cur = (cur % 1_000_000_000) * 10 + GetDigit(s[i]);
            if (i>8) {
                dict.TryGetValue(cur, out var count);
                dict[cur] = count+1;
            }
        }
        return dict.Where(pair => pair.Value>1).Select(pair => Decode(pair.Key)).ToList();
    }
    private int GetDigit(char c)
    {
        switch(c) {
            case 'A': return 1;
            case 'C': return 2;
            case 'G': return 3;
            case 'T': return 4;
        }
        return -1;
    }
    private char GetChar(long d)
    {
        switch(d) {
            case 1: return 'A';
            case 2: return 'C';
            case 3: return 'G';
            case 4: return 'T';
        }
        return 'X';
    }
    private string Decode(long val)
    {
        var list = new List<char>();
        while(val>0) {
            var d = val % 10;
            list.Add(GetChar(d));
            val = val/10;
        }
        list.Reverse();
        return new string(list.ToArray());
    }
}
