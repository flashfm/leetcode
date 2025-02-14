// Copyright (c) 2020 Alexey Filatov
// 66 - Plus One (https://leetcode.com/problems/plus-one)
// Date solved: 7/7/2020 5:49:34 AM +00:00
// Memory: 30.1 MB
// Runtime: 320 ms


public class Solution {
    public int[] PlusOne(int[] digits) {
        var result = new List<int>(digits);
        var over = false;
        for(var i = result.Count-1; i>=0; i--) {
            over = false;
            if (result[i]!=9) {
                result[i]++;
                break;
            }
            else {
                result[i] = 0;
                over = true;
            }
        }
        if (over) {
            result.Insert(0, 1);
        }
        return result.ToArray();
    }
}
