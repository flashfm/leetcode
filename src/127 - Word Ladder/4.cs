// Copyright (c) 2020 Alexey Filatov
// 127 - Word Ladder (https://leetcode.com/problems/word-ladder)
// Date solved: 2/8/2020 6:17:56 AM +00:00
// Memory: 28.1 MB
// Runtime: 468 ms


public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var list = new List<string>();
        list.Add(beginWord);
        list.AddRange(wordList);
        var n = list.Count;        
        var mx = new List<int>[n];
        for(var i=0;i<n;i++) mx[i] = new List<int>();
        for(var i=0;i<n;i++)
            for(var j=i+1;j<n;j++)
                    if (IsOneLetterDiff(list[i], list[j])) { mx[i].Add(j); mx[j].Add(i); }

        var target = list.IndexOf(endWord);
        if (target==-1) return 0;
        
        var q = new Queue<int>();
        var len = new int[n];
        len[0] = 1;
        q.Enqueue(0);
        
        var q2 = new Queue<int>();
        var len2 = new int[n];
        len2[target] = 1;
        q2.Enqueue(target);
        
        while(q.Count>0 && q2.Count>0) {
            var c = q.Dequeue();
            foreach(var i in mx[c]) {
                if (len2[i]!=0) return len2[i] + len[c];
                if (len[i]==0) {
                    q.Enqueue(i);
                    len[i] = len[c]+1;
                }
            }
            var c2 = q2.Dequeue();
            foreach(var i in mx[c2]) {
                if (len[i]!=0) return len[i] + len2[c2];
                if (len2[i]==0) {
                    q2.Enqueue(i);
                    len2[i] = len2[c2]+1;
                }
            }
        }
        
        return 0;
    }
    private bool IsOneLetterDiff(string a, string b)
    {
        var diff = 0;
        for(var i=0;i<a.Length;i++)  {
            if (a[i]!=b[i]) {
                if (diff==1) return false;
                diff++;
            }
        }
        return true;
    }
}
