// Copyright (c) 2024 Alexey Filatov
// 383 - Ransom Note (https://leetcode.com/problems/ransom-note)
// Date solved: 9/24/2024 9:37:13 PM +00:00
// Memory: 44.8 MB
// Runtime: 61 ms


public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var countByChar = new Dictionary<char, int>();
        foreach(var c in magazine) {
            countByChar[c] = countByChar.GetValueOrDefault(c) + 1;
        }
        foreach(var c in ransomNote) {
            if (!countByChar.TryGetValue(c, out var count) || count==0) {
                return false;
            }
            countByChar[c] = count-1;
        }
        return true;
    }
}
