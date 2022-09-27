// H-Index
// https://leetcode.com/problems/h-index
// Date solved: 08/12/2020 05:53:49 +00:00

// [3] -> h = 1
// [3,0] -> again h=1 since 0<1
// [3,0,6] -> have to increase h=2 due to count condition, 1 more element (6) added and it's more than 1+1, 0<2 and two others >= 2
// h is one of numbers from array
// [3,0,6,1] -> h=2, since added (1) is less than 2, count condition unchanged
// [3,0,6,1,5] -> h=3 again increase

//---
// sort
// [0,1,3,5,6]
// split them into two groups, right one of size S, so each from right is => than S, each from left is < S
// go from left to right
// [|0,1,3,5,6] h = 0 - nope
// [0|1,3,5,6] h = 1 - nope (5-1=4 elements should be <= 2)

// 1 element >= 1 a[n-h] >=1
// 4 elements <= 1 a[h-1] <= 1

// [0,1|3,5,6] h = 2 - nope (5-2=3 elements should be <= 2)
// [0,1,3|5,6] h = 3 - (5-3=2 - compare to left (3) and to right(5) - ok)
//    0 1 2 3 4
// h=3 -> last 3 should be 3+ - it's like that if a[2](5-3) is >=3
//     -> first 2 should be 3- it's like that if a[1](5-3-1) is <=3

// [0,1,3,5|6] h = 4 - nope

// {0,1,(3},5,6)

// 0,0,0,1,1 -> h=1
// if h would be 2 then last 2 elems should be 2+ and first 3 should be 2-

//[0] => h=0 => if 1 elem -> 0 if its 0 otherwise 1

//[1,7,9,4]

//[1,4,7,9]
//h=3

public class Solution {
    public int HIndex(int[] citations) {
        if (citations==null || citations.Length==0) return 0;
        Array.Sort(citations);
        var n = citations.Length;
        var maxH = 0;
        for(var h=1;h<=n;h++) {
            if (citations[n-h]>=h && (n-h==0 || citations[n-h-1]<=h)) {
                maxH = h;
            }
        }
        return maxH;
    }
}
