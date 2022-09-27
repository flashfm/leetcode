// Jump Game
// https://leetcode.com/problems/jump-game
// Date solved: 12/24/2019 08:13:23 +00:00

public class Solution {
   public bool CanJump(int[] nums) {
        var prevMax = nums[0];
        for(var i=1;i<nums.Length;i++) {
            if (i > prevMax) return false;
            prevMax = Math.Max(prevMax, nums[i]+i);
        }        
        return true;
    }
}
