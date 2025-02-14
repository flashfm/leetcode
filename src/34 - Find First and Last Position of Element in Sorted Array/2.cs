// Copyright (c) 2020 Alexey Filatov
// 34 - Find First and Last Position of Element in Sorted Array (https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array)
// Date solved: 1/31/2020 8:31:32 AM +00:00
// Memory: 31.9 MB
// Runtime: 240 ms


public class Solution {
    int[] nums;
    int t;
    int[] none = new[] {-1,-1};
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length==0) return none;
        this.nums = nums;
        t = target;
        return Rec(0, nums.Length-1);
    }  
    private int[] Rec(int l, int r, bool leftOnly = false, bool rightOnly = false)
    {
        if (l>r || (l==r && nums[l]!=t)) return none;
        if (nums[l]==t && nums[r]==t) return new[] {l,r};
        var m = (l+r)/2;
        var nm = nums[m];
        if (nm<t) return Rec(m+1, r);
        if (nm>t) return Rec(l, m-1);
        
        var lc = rightOnly ? -1 : Rec(l,m-1, leftOnly: true)[0];
        var rc = leftOnly ? -1 : Rec(m+1,r, rightOnly: true)[1];
        return new[] { lc>-1 ? lc : m, rc>-1 ? rc : m };
    }
}
