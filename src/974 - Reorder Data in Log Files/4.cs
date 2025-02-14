// Copyright (c) 2024 Alexey Filatov
// 974 - Reorder Data in Log Files (https://leetcode.com/problems/reorder-data-in-log-files)
// Date solved: 10/27/2024 5:19:35 AM +00:00
// Memory: 52.8 MB
// Runtime: 10 ms


public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        var digitLogs = new List<string>(logs.Length);
        var wordLogs = new List<(int space, string line)>(logs.Length);
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
        var result = new List<string>(logs.Length);
        result.AddRange(wordLogs.OrderBy(l => l.line.Substring(l.space+1)).ThenBy(l => l.line.Substring(0, l.space)).Select(l => l.line));
        result.AddRange(digitLogs);
        return result.ToArray();
    }
}
