// Copyright (c) 2024 Alexey Filatov
// 68 - Text Justification (https://leetcode.com/problems/text-justification)
// Date solved: 8/26/2024 2:23:37 AM +00:00
// Memory: 47 MB
// Runtime: 104 ms


public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var lines = new List<List<string>>();
        var line = new List<string>();
        var lineLength = 0;
        lines.Add(line);
        foreach(var word in words) {
            var addSpace = lineLength == 0 ? 0 : 1;            
            if (lineLength + word.Length + addSpace <= maxWidth) {
                if (addSpace==1) {
                    lineLength++; // add space
                }
                line.Add(word);
                lineLength += word.Length;
            }
            else {
                line = new List<string>();
                lines.Add(line);
                line.Add(word);
                lineLength = word.Length;
            }
        }
        var result = new List<string>();
        for(var i = 0; i<lines.Count-1; i++) {
            result.Add(Pad(lines[i], maxWidth, false));
        }
        result.Add(Pad(lines.Last(), maxWidth, true));
        return result;
    }
    private string Pad(List<string> words, int width, bool singleSpace)
    {
        var sb = new StringBuilder();
        var totalSpaces = singleSpace ? words.Count - 1 : width - words.Select(w => w.Length).Sum();
        var n = words.Count;
        foreach(var word in words) {
            if (n != words.Count) {
                var pad = totalSpaces / n;
                if (totalSpaces % n != 0) {
                    pad++;
                }
                totalSpaces -= pad;
                sb.Append(new string(' ', pad));
            }
            sb.Append(word);
            n--;
        }
        if (sb.Length<width) {
            sb.Append(new string(' ', width - sb.Length));
        }
        return sb.ToString();
    }
}
