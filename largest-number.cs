// Largest Number
// https://leetcode.com/problems/largest-number
// Date solved: 10/23/2020 05:28:28 +00:00

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
        if (nums.All(n => n==0)) return "0";
        Array.Sort(nums, (a,b)=>Compare(a,b));
        return string.Join("", nums);
    }
    private static int Compare(int a, int b)
    {
        if (a==0 && b==0) return 0;
        if (a==0) return 1;
        if (b==0) return -1;
        var alen = Len(a);
        var blen = Len(b);
        long x = a * (long)Math.Pow(10, blen) + b;
        long y = b * (long)Math.Pow(10, alen) + a;
        return -x.CompareTo(y);
    }
    private static int Len(int a) => (int)Math.Log10(a)+1;
}
