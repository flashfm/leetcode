// Happy Number
// https://leetcode.com/problems/happy-number
// Date solved: 04/09/2020 05:50:22 +00:00

public class Solution {
    public bool IsHappy(int n) {
        var slow = n;
        var fast = n;
        do {
            slow = sum(slow);
            fast = sum(sum(fast));
        }
        while(slow!=fast);
        return slow==1;
    }
    private int sum(int n)
    {
        var newNumber = 0;
        var c = n;            
        while(c>0) {
            var d = c % 10;
            newNumber += (int)Math.Pow(d, 2);
            c = c / 10;
        }
        return newNumber;
    }
}
