// Find Peak Element
// https://leetcode.com/problems/find-peak-element
// Date solved: 01/31/2020 06:58:43 +00:00

public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length==0) return 0;
                
        var l = 0;
        var r = nums.Length-1;

        while(true) {
            if (l==r) return l;
            if (nums[l]>nums[l+1]) return l;
            if (nums[r-1]<nums[r]) return r;

            var m = (l + r) / 2;
            
            if (nums[m]>nums[m-1] && nums[m]>nums[m+1]) return m;
            
            if (nums[l]>=nums[m]) {
                r = m; // go left
                continue;
            }

            if (nums[r]>=nums[m]) {
                l = m; // go right
                continue;
            }
            
            if (nums[m-1]<nums[m]) {
                l = m; // go right
                continue;
            }
            
            r = m; // go left
        }
    }
}
