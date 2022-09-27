// Rotate Array
// https://leetcode.com/problems/rotate-array
// Date solved: 03/14/2020 01:31:13 +00:00

public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums==null) return;
        
        var n = nums.Length;
        if (n==0) return;
        
        k %= n;        
        if (k==0) return;

        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, n-k);
    }
}
