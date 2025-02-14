// Copyright (c) 2019 Alexey Filatov
// 75 - Sort Colors (https://leetcode.com/problems/sort-colors)
// Date solved: 12/23/2019 6:50:29 AM +00:00
// Memory: 29.3 MB
// Runtime: 236 ms


public class Solution {
    public void SortColors(int[] nums) {
        var zerosIndex = 0;
        var twosIndex = nums.Length-1;
        var i = 0;
        while(i<=twosIndex) {
            if (nums[i]==0) {
                swap(nums, zerosIndex, i);
                zerosIndex++;
                i++;
            }
            else if (nums[i]==2) {
                swap(nums, twosIndex, i);
                twosIndex--;
            }
            else {
                i++;
            }
        }
    }
    
    private void swap(int[] nums, int a, int b)
    {
        var tmp = nums[a];
        nums[a] = nums[b];
        nums[b] = tmp;
    }
}
