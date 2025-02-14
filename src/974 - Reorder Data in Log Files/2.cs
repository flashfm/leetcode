// Copyright (c) 2024 Alexey Filatov
// 974 - Reorder Data in Log Files (https://leetcode.com/problems/reorder-data-in-log-files)
// Date solved: 10/27/2024 5:16:52 AM +00:00
// Memory: 53.1 MB
// Runtime: 13 ms


public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        var digitLogs = new List<string>();
        var wordLogs = new List<(int space, string line)>();
        foreach(var line in logs) {
            var space = line.IndexOf(' ');
            var isDigit = true;
            for(var i = space+1; i<line.Length;i++) {
                var c = line[i];
                if (c!=' ' && !char.IsDigit(c)) {
                    isDigit = false;
                    break;
                }
            }
            if (isDigit) {
                digitLogs.Add(line);
            }
            else {
                wordLogs.Add((space, line));
            }
        }
        var result = wordLogs.OrderBy(l => l.line.Substring(l.space+1)).ThenBy(l => l.line.Substring(0, l.space)).Select(l => l.line).ToList();
        result.AddRange(digitLogs);
        return result.ToArray();
    }
}
