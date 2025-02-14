// Copyright (c) 2020 Alexey Filatov
// 412 - Fizz Buzz (https://leetcode.com/problems/fizz-buzz)
// Date solved: 3/11/2020 5:48:47 AM +00:00
// Memory: 33.7 MB
// Runtime: 236 ms


public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();
        for(var i=1;i<=n;i++) {
            var s = "";
            if (i%3==0) s += "Fizz";
            if (i%5==0) s += "Buzz";
            if (s.Length==0) s = IntToString(i);
            result.Add(s);
        }
        return result;
    }
    
    private string IntToString(int n)
    {
        var len = (int)Math.Log10(n)+1;
        var sb = new char[len];
        var d = "0123456789";
        var i = len-1;
        while(n>0) {
            sb[i--] = d[n%10];
            n = n / 10;
        }
        return new string(sb);
    }
}
