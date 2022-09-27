// Remove Duplicates from Sorted Array
// https://leetcode.com/problems/remove-duplicates-from-sorted-array
// Date solved: 02/18/2020 06:07:35 +00:00

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length==0) return 0;
        var j = 1;
        for(var i=1;i<nums.Length;i++) {
            if (nums[i]!=nums[j-1]) {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}
