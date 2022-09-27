// Move Zeroes
// https://leetcode.com/problems/move-zeroes
// Date solved: 04/09/2020 05:59:56 +00:00

public class Solution {
    public void MoveZeroes(int[] nums) {
        var pos = 0;
        int right = 0;
        
        while(pos<nums.Length && right<nums.Length) {
            while(pos<nums.Length && nums[pos]!=0) pos++;
            right = pos+1;
            while(right<nums.Length && nums[right]==0) right++;
            
            if (right<nums.Length)
                swap(nums, pos, right);
        }
    }
    private void swap(int[] nums, int a, int b)
    {
        var t = nums[a];
        nums[a] = nums[b];
        nums[b] = t;
    }
}
