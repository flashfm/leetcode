// Copyright (c) 2024 Alexey Filatov
// 974 - Reorder Data in Log Files (https://leetcode.com/problems/reorder-data-in-log-files)
// Date solved: 10/27/2024 5:00:56 AM +00:00
// Memory: 53.4 MB
// Runtime: 11 ms


public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        var digitLogs = new List<string>();
        var wordLogs = new List<(string id, string content, string line)>();
        foreach(var line in logs) {
            var space = line.IndexOf(' ');
            var content = line.Substring(space+1);
            var isDigit = true;
            foreach(var c in content) {
                if (c!=' ' && !char.IsDigit(c)) {
                    isDigit = false;
                    break;
                }
            }
            if (isDigit) {
                digitLogs.Add(line);
            }
            else {
                var id = line.Substring(0, space);
                wordLogs.Add((id, content, line));
            }
        }
        var result = wordLogs.OrderBy(l => l.content).ThenBy(l => l.id).Select(l => l.line).ToList();
        result.AddRange(digitLogs);
        return result.ToArray();
    }
}
