// Word Break II
// https://leetcode.com/problems/word-break-ii
// Date solved: 08/04/2020 08:45:06 +00:00

public class Solution {
    
    public class Node
    {
        public char Val;
        public Dictionary<char, Node> ChildByVal = new Dictionary<char, Node>();
        public bool IsTerminal;
        public int WordIndex;
    }
    
    private Node root;
    private List<string> result = new List<string>();
    private IList<string> wordDict;
    private List<int> stack = new List<int>();
    private int stackLen = 0;
    
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        this.wordDict = wordDict;
        root = new Node();
        var allChars = new HashSet<char>();
        for(var j = 0; j<wordDict.Count; j++) {
            var word = wordDict[j];
            var node = root;
            for(var i = 0; i<word.Length; i++) {
                var val = word[i];
                allChars.Add(val);
                if (!node.ChildByVal.TryGetValue(val, out var child)) {
                    node.ChildByVal[val] = child = new Node { Val = val };
                }
                if (i == word.Length-1) {
                    child.IsTerminal = true;
                    child.WordIndex = j;
                }
                node = child;
            }
        }
        foreach(var c in s) {
            if (!allChars.Contains(c)) {
                return result;
            }
        }
        
        WordBreak(s, 0);
        
        return result;
    }    
    
    private void WordBreak(string s, int start)
    {
        var node = root;
        // i is a len of word
        for(var i = 1; i<=s.Length - start; i++) {            
            var c = s[start+i-1];
            if (!node.ChildByVal.TryGetValue(c, out var child)) {
                break;
            }
            if (child.IsTerminal) {
                if (stackLen==stack.Count) {
                    stack.Add(child.WordIndex);
                }
                else {
                    stack[stackLen] = child.WordIndex;
                }
                stackLen++;
                if (i==s.Length-start) {
                    var sb = new StringBuilder();
                    for(var j=0;j<stackLen;j++) {
                        if (sb.Length>0) sb.Append(" ");
                        sb.Append(wordDict[stack[j]]);
                    }
                    result.Add(sb.ToString());
                }
                else {
                    WordBreak(s, start+i);
                }
                stackLen--;
            }
            node = child;
        }
    }    
}
