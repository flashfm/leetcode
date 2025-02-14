// Copyright (c) 2022 Alexey Filatov
// 395 - Longest Substring with At Least K Repeating Characters (https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters)
// Date solved: 11/6/2022 4:03:49 AM +00:00
// Memory: 35.1 MB
// Runtime: 115 ms


public class Solution {
    public int LongestSubstring(string s, int k) {
        // aaabbcaaabb, k = 4
        // ищем "стоп-символы" - тех, которых не хватает - нету - значит "пробуем" отрезок и выход
        // на отрезках между стоп-символами запускаем тот же самый алгоритм
        return Math.Max(0, CheckRange(s, k, 0, s.Length-1));
    }

    private int CheckRange(string s, int k, int start, int end)
    {
        if (end-start < k-1) return int.MinValue;
        var countByChar = new Dictionary<char, int>();
        for(var i = start; i<=end; i++) {
            var c = s[i];
            countByChar.TryGetValue(c, out var count);
            countByChar[c] = count+1;
        }
        var stopChars = countByChar.Where(p => p.Value < k).Select(p => p.Key).ToHashSet();
        //Console.WriteLine($"{start}-{end},{string.Join(',',stopChars)}");
        if (stopChars.Count==0) {
            return end - start + 1;
        }
        var newStart = start;
        var max = int.MinValue;
        for(var i = start; i<=end; i++) {
            var c = s[i];
            if (stopChars.Contains(c)) {
                max = Math.Max(max, CheckRange(s, k, newStart, i-1));
                newStart = i+1;
            }
        }
        max = Math.Max(max, CheckRange(s, k, newStart, end));
        return max;
    }
}
