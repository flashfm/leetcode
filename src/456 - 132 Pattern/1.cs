// Copyright (c) 2020 Alexey Filatov
// 456 - 132 Pattern (https://leetcode.com/problems/132-pattern)
// Date solved: 10/26/2020 7:45:59 AM +00:00
// Memory: 28.4 MB
// Runtime: 100 ms


/*
 /\
/ 

*/

public class Range
{
    public int L;
    public int R;
}

public class Solution {
    public bool Find132pattern(int[] nums) {
        var n = nums.Length;
        if (n<2) return false;
        var ranges = new List<Range>();
        var l = int.MaxValue;
        var r = int.MaxValue;
        for(var i=0;i<n;i++) {
            //Console.WriteLine($"mid: {mid}, min: {min}");
            var num = nums[i];
            
            if (l<r && num<r) {
                // new range
                Console.WriteLine($"{l},{r}");
                Add(ranges, l, r);
                l = int.MaxValue;
                r = int.MaxValue;
            }
                        
            if (num>r) {
                r = num;
            }
            
            if (num<l) {
                l = r = num;
            }
                        
            if (Contains(ranges, num)) {
                return true;
            }
        }
        return false;
    }
    private void Add(List<Range> ranges, int l, int r)
    {
        var merged = false;
        if (ranges.Count>0) {
            var range = ranges[ranges.Count-1];
            if (l<range.L && r>=range.L) {
                range.L = l;
                merged = true;
            }
            if (r>range.R && l<=range.R) {
                range.R = r;
                merged = true;
            }
        }
        if (!merged) {
            ranges.Add(new Range { L = l, R = r });
        }
    }
    
    private bool Contains(List<Range> ranges, int num)
    {
        var l = 0;
        var r = ranges.Count-1;
        while(l<=r) {
            var m = (l+r)/2;
            var rm = ranges[m];
            if (rm.L < num && num < rm.R) return true;
            if (num > rm.L) {
                r = m-1;
            }
            else {
                l = m+1;
            }
        }
        return false;
    }
}
