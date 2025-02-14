// Copyright (c) 2020 Alexey Filatov
// 179 - Largest Number (https://leetcode.com/problems/largest-number)
// Date solved: 10/23/2020 5:32:15 AM +00:00
// Memory: 25.8 MB
// Runtime: 108 ms


// only 1-digit nums
// sort desc, insert num
// 2 3 5, 8
// 8532, 7
// 87532 vs 85732

// 2-digit and 1-digit
// 22 3 55 -> sort desc "alphabetically", insert num
// 55 3 22, 34; 34 > 3
// (5533422 vs 5534322)

// 55 3 22, 32; 32 < 3; 33 = 3
// 5533222 vs 5532322

// 55 22, 21; 22 > 21
// 552221 vs 552122

// comparison - if digit1 = digit2 => i1++ and i2++ (if we can), unless we find < or >

// => sort array based on such comparison ^

public class Solution {
    public string LargestNumber(int[] nums) {
        if (nums.Length==0) return "";
        Array.Sort(nums, (a,b)=>Compare(a,b));
        if (nums[0]==0) return "0";
        return string.Join("", nums);
    }
    private static int Compare(int a, int b)
    {
        if (a==0 && b==0) return 0;
        if (a==0) return 1;
        if (b==0) return -1;
        long x = a * (long)Math.Pow(10, Len(b)) + b;
        long y = b * (long)Math.Pow(10, Len(a)) + a;
        return y.CompareTo(x);
    }
    private static int Len(int a) => (int)Math.Log10(a)+1;
}
