// Copyright (c) 2024 Alexey Filatov
// 43 - Multiply Strings (https://leetcode.com/problems/multiply-strings)
// Date solved: 12/18/2024 11:11:07 PM +00:00
// Memory: 42.1 MB
// Runtime: 12 ms


public class Solution {
    public string Multiply(string num1, string num2) {
        var mulCache = new List<int>[10];

        var num1arr = num1.Select(c => c-'0').Reverse().ToArray();
        var result = new List<int>();
        for(var i=num2.Length-1; i>=0; i--) {
            var a = Mul(num2[i]-'0'); // reversed array, starts with lowest pos
            Add(a, num2.Length-i-1);
        }
        return result.All(r => r==0) ? "0" : new string(result.Select(i => (char)('0'+i)).Reverse().ToArray());

        List<int> Mul(int d)
        {
            if (mulCache[d]!=null) {
                return mulCache[d];
            }
            var rem = 0;
            var res = new List<int>(num1arr.Length+1);
            foreach(var x in num1arr) {
                var r = x*d + rem;
                res.Add(r%10);
                rem = r/10;
            }
            if (rem!=0) {
                res.Add(rem);
            }
            mulCache[d] = res;
            return res;
        }

        void Add(List<int> val, int zeros)
        {
            var rem = 0;
            for(var j=0; j<val.Count; j++) {
                var resPos = zeros+j;
                var x = val[j] + rem;
                if (resPos<result.Count) {
                    x += result[resPos];
                    result[resPos] = x%10;
                }
                else {
                    result.Add(x%10);
                }
                rem = x/10;
            }
            if (rem>0) {
                result.Add(rem);
            }
        }
    }
}
