// Copyright (c) 2020 Alexey Filatov
// 189 - Rotate Array (https://leetcode.com/problems/rotate-array)
// Date solved: 3/12/2020 6:53:28 AM +00:00
// Memory: 32.2 MB
// Runtime: 252 ms


public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums==null || nums.Length==0) return;
        
        k = k % nums.Length;        
        if (k==0) return;
        
        var n = nums.Length;
        
        var z = n - k;
        if (k < z) {
            for (var i = 0; i < k; i++) swap(nums, i, n - k + i);
            swaprec(nums, k, n - 1 - k, n - k, n - 1);
        }
        else {
            for (var i = 0; i < z; i++) swap(nums, i, n - z + i);
            swaprec(nums, 0, z-1, z, n - z - 1);
        }
    }
    
    private void swaprec(int[] n, int al, int ar, int bl, int br)
    {
        var alen = ar-al+1;
        var blen = br-bl+1;
        if (alen<=0 || blen<=0) return;
        if (alen>blen) {
            for(var i = 0; i<blen; i++) swap(n, al+i, bl+i);
            swaprec(n, al+blen, bl-1, bl, br);
        }
        else {
            for(var i = 0; i<alen; i++) swap(n, al+i, bl+i);
            swaprec(n, bl, bl+alen-1, bl+alen, br);
        }
    }
    
    private void swap(int[] n, int a, int b)
    {
        var t = n[a];
        n[a] = n[b];
        n[b] = t;
    }
}
