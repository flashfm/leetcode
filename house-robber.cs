// House Robber
// https://leetcode.com/problems/house-robber
// Date solved: 03/18/2020 05:21:13 +00:00

public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;
        if (n==0) return 0;
        var withLast = nums[0];
        var withoutLast = 0;
        for(var i=1;i<n;i++) {
            var prevWithLast = withLast;
            withLast = nums[i] + withoutLast;
            withoutLast = Math.Max(withoutLast, prevWithLast);
        }
        return Math.Max(withLast, withoutLast);
    }
}
