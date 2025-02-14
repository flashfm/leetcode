// Copyright (c) 2019 Alexey Filatov
// 202 - Happy Number (https://leetcode.com/problems/happy-number)
// Date solved: 12/29/2019 9:58:37 PM +00:00
// Memory: 16.4 MB
// Runtime: 44 ms


public class Solution {
    public bool IsHappy(int n) {
        var prevNumbers = new HashSet<int>(new[] {n});
        var prevNumber = n;
        while(true) {
            var newNumber = 0;
            var c = prevNumber;            
            while(c>0) {
                var d = c % 10;
                newNumber += (int)Math.Pow(d, 2);
                c = c / 10;
            }
            if (newNumber==1) {
                return true;
            }
            if (prevNumbers.Contains(newNumber)) {
                return false;
            }
            prevNumbers.Add(newNumber);
            prevNumber = newNumber;
        }
    }
}
