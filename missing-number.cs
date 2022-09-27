// Missing Number
// https://leetcode.com/problems/missing-number
// Date solved: 03/20/2020 07:45:21 +00:00

public class Solution {
    public int MissingNumber(int[] nums) {
        var min = int.MaxValue;
        var max = int.MinValue;
        var sum = 0;
        foreach(var n in nums) {
            if (n<min) min = n;
            if (n>max) max = n;
            sum += n;
        }
        var result = (max-min+1)*(min+max)/2 - sum;
        return result==0 ? (min>0 ? min-1 : max+1) : result;
    }
}
